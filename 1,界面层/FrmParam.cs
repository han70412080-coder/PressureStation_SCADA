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

        
    }
}
