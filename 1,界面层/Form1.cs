using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using xbd.ControlLib;
using xbd.s7netplus;
using 加压站SCADA._1_界面层;
namespace 加压站SCADA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            cts = new CancellationTokenSource();
            this.FormClosing += Form1_FormClosing;
            
            updateDateTimer.Interval = 500;
            updateDateTimer.Enabled = true;
            updateDateTimer.Tick += UpdateDateTimer_Tick;
        }
        System.Windows.Forms.Timer updateDateTimer = new System.Windows.Forms.Timer();
        private bool IsFirstScan = true;
        private readonly CultureInfo _cultureInfo = new CultureInfo("en-US");
        MessageFilter messageFilter;
        private void UpdateDateTimer_Tick(object sender, EventArgs e)
        {
            lbl_DateShow.Text = DateTime.Now.ToString("yyyy-MM-dd HH mm ss dddd", _cultureInfo);

            if (sysInfo.ScreenTime>0)
            {
                Program.TickCount++;
                
                if (sysInfo.ScreenTime*1000/ updateDateTimer.Interval==Program.TickCount)
                {
                    LockWorkStation();
                }
            }
        }
        PlcDataService plcDataService = new PlcDataService();
        //中间转存数据对象
        private readonly object _dataLock = new object();
        private PlcData _lastedPlcData = new PlcData();
        //定时刷新，定时断线重连扫描令牌
        private CancellationTokenSource cts;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sysInfo = sysInfoService.GetSysInfoFromPath(iniPath);
            Task.Run(new Action(() =>
            {
                PLCCommunication();
            }));

            if (sysInfo.ScreenTime>0)
            {
                messageFilter = new MessageFilter();
                Application.AddMessageFilter(messageFilter);
            }
        }
        #region PLCCommunication 断线重连 定时刷新
        private void PLCCommunication()
        {
            while (!cts.IsCancellationRequested)
            {
                try
                {
                    //如果没有连接上，那么连接
                    if (!plcDataService.IsConnected)
                    {
                        plcDataService.Connect(this.sysInfo);
                        Thread.Sleep(1000);
                        continue;
                    }
                    //如果连接上了，那么新建转存对象，读取转存——lastedPlcData
                    PlcData data = plcDataService.ReadPlcData().Content;
                    lock (_dataLock)
                    {
                        _lastedPlcData = data;
                    }
                    // ========== 读到数据，调用UI更新方法 ==========
                    UpdateUIData(data);
                    Thread.Sleep(200);
                }
                catch (Exception)
                {
                    plcDataService.IsConnected = false;
                    Thread.Sleep(3000);
                }
                Thread.Sleep(500);
            }
        }
        /// 

        /// 跨线程安全UI更新方法，由PLC后台线程调用
        /// 
        private void UpdateUIData(PlcData plcData)
        {
            // 1. 安全前置检查：如果窗体句柄还没创建，或者窗体已经关闭，直接退出
            if (!this.IsHandleCreated || this.IsDisposed)
            {
                return;
            }
            // 2. 跨线程判断：如果当前不是UI主线程，投递任务给UI线程
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<PlcData>(UpdateUIData), plcData);
                return; //投递后直接return，后台线程不再往下执行UI赋值
            }
            // ================= 以下全部是原来timer_Refresh_Tick的UI刷新代码 =================
            try
            {
                if (IsFirstScan)
                {
                    toggle_PumpIn1.Checked = plcData.InPump1State;
                    toggle_PumpIn2.Checked = plcData.InPump2State;
                    IsFirstScan = false;
                }
                lbl_PressureIn.Text = plcData.PressureIn.ToString("f2") + " Bar";
                lbl_Pressout.Text = plcData.PressureOut.ToString("f2") + " Bar";
                ms_TempIn1.ParamValue = plcData.TempIn1;
                ms_TempIn2.ParamValue = plcData.TempIn2;
                ms_TempOut.ParamValue = plcData.TempOut;
                ms_PressureTank1.ParamValue = plcData.PressureTank1;
                ms_PressureTank2.ParamValue = plcData.PressureTank2;
                ms_PressureTankOut.ParamValue = plcData.PressureTankOut;
                led_PlcConnState.State = plcDataService.IsConnected;
                led_SysRunState.State = plcData.SysRunState;
                led_SysAlarmState.State = plcData.SysAlarmState;
                lbl_PressureTank1.Text = plcData.PressureTank1.ToString("f2");
                lbl_PressureTank2.Text = plcData.PressureTank2.ToString("f2");
                lbl_Leveltank1.Text = plcData.LevelTank1.ToString("f2");
                lbl_Leveltank2.Text = plcData.LevelTank2.ToString("f2");
                lbl_PressureOut.Text = plcData.PressureOut.ToString("f2");
                lbl_TempIn1.Text = plcData.TempIn1.ToString("f2");
                lbl_TempIn2.Text = plcData.TempIn2.ToString("f2");
                lbl_TempOut.Text = plcData.TempOut.ToString("f2");
                lbl_PreTankOut.Text = plcData.PressureTankOut.ToString("f2");
                wave_Tank1.Value = Convert.ToInt32(plcData.LevelTank1 * 100.0f);
                wave_Tank2.Value = Convert.ToInt32(plcData.LevelTank2 * 100.0f);
                pump_In1.IsRun = plcData.InPump1State;
                pump_In2.IsRun = plcData.InPump2State;
                valve_In.State = plcData.ValveInState;
                valve_Out.State = plcData.ValveOutState;
                motor_Pump1.PumpState = plcData.CirclePump1State ? PumpState.运行 : PumpState.停止;
                motor_Pump2.PumpState = plcData.CirclePump2State ? PumpState.运行 : PumpState.停止;
                btn_Pump1.Text = plcData.CirclePump1State ? "停止" : "运行";
                btn_Pump2.Text = plcData.CirclePump2State ? "停止" : "运行";
            }
            catch
            {
                //UI控件赋值异常保护，防止界面报错直接把PLC后台循环干掉
            }
        }
        #endregion
        #region 参数设置点击事件
        //Ini配置文件地址
        string iniPath = Application.StartupPath + "\\SysStartIni.ini";
        //SysInfoService以类的方式读取配置文件
        SysInfoService sysInfoService = new SysInfoService();
        //SysInfo读取类存放配置文件
        SysInfo sysInfo = new SysInfo();
        /// 
        /// 参数设置点击事件
        /// 
        /// 
        /// 
        private void btn_ParamSet_Click(object sender, EventArgs e)
        {
            if (sysInfo.IPAddress != null)
            {
                new FrmParam(sysInfo, sysInfoService, iniPath).ShowDialog();
            }
        }
        #endregion
        private void toggle_PumpIn1_CheckedChanged(object sender, EventArgs e)
        {
            bool writeResult = plcDataService.InPump1Control(toggle_PumpIn1.Checked);
            if (writeResult == false)
            {
                toggle_PumpIn1.CheckedChanged -= toggle_PumpIn1_CheckedChanged;
                toggle_PumpIn1.Checked = false;
                toggle_PumpIn1.CheckedChanged += toggle_PumpIn1_CheckedChanged;
            }
        }
        private void toggle_PumpIn2_CheckedChanged(object sender, EventArgs e)
        {
            bool result = plcDataService.InPump2Control(toggle_PumpIn2.Checked);
            if (result == false)
            {
                toggle_PumpIn2.CheckedChanged -= toggle_PumpIn2_CheckedChanged;
                toggle_PumpIn2.Checked = false;
                toggle_PumpIn2.CheckedChanged += toggle_PumpIn2_CheckedChanged;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Pump1_Click(object sender, EventArgs e)
        {
            plcDataService.CirclePump1Control(btn_Pump1.Text == "运行");
        }
        private void btn_Pump2_Click(object sender, EventArgs e)
        {
            plcDataService.CirclePump2Control(btn_Pump2.Text == "运行");
        }
        private void valve_In_Load(object sender, EventArgs e)
        {
            string msg = "进水阀1";
        }
        private void CommonValveControl(object sender, EventArgs e)
        {
            if (sender is xbdValve xbdValve)
            {
                new FrmValveControl(xbdValve.ValveName, xbdValve.State, this.plcDataService).ShowDialog();
            }
        }
        #region 系统锁屏

        [DllImport("user32")]
        public static extern bool LockWorkStation();

        #endregion

    }

    #region 消息筛选器 
    public class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            //如果检测到有鼠标或则键盘的消息，则使计数为0.....
            if (m.Msg == 0x0200 || m.Msg == 0x0201 || m.Msg == 0x0204 || m.Msg == 0x0207)
            {
                MessageBox.Show("Tick" + Program.TickCount);

            }
            return false;
        }
    }
    #endregion
}