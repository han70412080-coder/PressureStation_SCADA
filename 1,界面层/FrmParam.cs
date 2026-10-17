using AForge.Video.DirectShow;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.s7netplus;
using 加压站SCADA._1_界面层;

namespace 加压站SCADA
{
    public partial class FrmParam : Form
    {
        
        public FrmParam(SysInfo sysInfo, SysInfoService sysInfoService, string iniPath)
        {
            this.sysInfo = sysInfo;
            this.sysInfoService = sysInfoService;
            this.iniPath = iniPath;

            InitializeComponent();
            this.Load += FrmParam_Load;
            //Enter=确定键
            this.AcceptButton = btn_PlcSet;


        }

        private void FrmParam_Load(object sender, EventArgs e)
        {
            cmb_CpuType.DataSource = Enum.GetNames(typeof(CpuType));
            cmb_CpuType.Text = sysInfo.CpuType.ToString();
            txt_IPAddress.Text = sysInfo.IPAddress;
            txt_Rack.Text = sysInfo.Rack.ToString();
            txt_Slot.Text = sysInfo.Slot.ToString();

            toggle_AutoStart.Checked = sysInfo.AutoStart;
            txt_ScreenTime.Text = sysInfo.ScreenTime.ToString();
            txt_LogoutTime.Text = sysInfo.LogoutTime.ToString();
            this.toggle_AutoStart.Click += toggle_AutoStart_CheckedChanged;


            FilterInfoCollection infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in infoCollection)
            {
                cmb_Camera.Items.Add(item);
            }
            if (cmb_Camera.SelectedIndex<infoCollection.Count)
            {
                cmb_Camera.SelectedIndex = sysInfo.CameraIndex;
            }
        }

        public SysInfo sysInfo { get; }
        public SysInfoService sysInfoService { get; }
        public string iniPath { get; }
        

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 无边框拖动 

        private Point mPoint;



        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        private void btn_PlcSet_Click(object sender, EventArgs e)
        {
            if (sysInfo==null)
            {
                SysInfo sysInfo = new SysInfo();
            }
            else
            {
                sysInfo.IPAddress = txt_IPAddress.Text;
                sysInfo.CpuType = (CpuType)Enum.Parse(typeof(CpuType), cmb_CpuType.Text.ToString().Trim(), true);
                sysInfo.Rack = Convert.ToInt16(txt_Rack.Text.Trim());
                sysInfo.Slot = Convert.ToInt16(txt_Slot.Text.Trim());

                sysInfo.AutoStart = this.toggle_AutoStart.Checked;
                sysInfo.ScreenTime = Convert.ToInt32(txt_ScreenTime.Text.Trim());
                sysInfo.LogoutTime = Convert.ToInt32(txt_LogoutTime.Text.Trim());
                //摄像头

                bool reslut = sysInfoService.SetSysInfoToPath(sysInfo, this.iniPath);
                if (reslut)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    new FrmMsgNoAck("写入失败", "通信参数").ShowDialog();
                }

            }
        }

        private void btn_PlcCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void toggle_AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            AutoStart(this.toggle_AutoStart.Checked);
        }

        #region 开机启动
        /// <summary>  
        /// 修改程序在注册表中的键值  
        /// </summary>  
        /// <param name="isAuto">true:开机启动,false:不开机自启</param> 
        private void AutoStart(bool isAuto = true)
        {
            if (isAuto == true)
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.SetValue("PressurizationStationPro", System.Windows.Forms.Application.ExecutablePath);
                R_run.Close();
                R_local.Close();
            }
            else
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                R_run.DeleteValue("PressurizationStationPro", false);
                R_run.Close();
                R_local.Close();
            }
        }
        #endregion
    }
}
