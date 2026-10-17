using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.ControlLib;

namespace 加压站SCADA._1_界面层
{
    public partial class FrmValveControl : Form
    {
        public string valveName { get; set; }
        public bool state { get; set; }
        public PlcDataService plcDataService { get; set; }
        public FrmValveControl(string valveName,bool state,PlcDataService plcDataService)
        {
            this.TopMost = true;
            InitializeComponent();
            this.valveName = valveName;
            this.state = state;
            this.plcDataService = plcDataService;
            this.lbl_Title.Text = "阀门控制";
            lbl_TipMsg.Text = "是否要" + (!state ? "打开" : "关闭") +valveName+ "?";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (plcDataService.IsConnected)
            {
                    bool result = default;
                    switch (valveName)
                    {
                        case  "进水阀":
                            result= plcDataService.ValveInControl(!state);
                            break;
                        case "出水阀":
                            result=plcDataService.ValveOutControl(!state);
                            break;
                        default:
                            new FrmMsgNoAck("阀门名称错误，检查", "阀门控制").ShowDialog();
                            break;
                    }
                    if (result)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        new FrmMsgNoAck("修改失败", "阀门控制").ShowDialog();
                    }
                
            }
            else
            {
                new FrmMsgNoAck("请检查PLC连接", "阀门控制").ShowDialog();
            }

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

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
