using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 加压站SCADA._1_界面层
{
    public partial class FrmMsgNoAck : Form
    {
        public FrmMsgNoAck(string Msg,string Title)
        {
            InitializeComponent();

            this.TopMost = true;
            lbl_TipMsg.Text = Msg;
            lbl_Title.Text = Title;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

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

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
