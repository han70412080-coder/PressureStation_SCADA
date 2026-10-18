using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.PressurizationStationPro;

namespace 加压站SCADA._1_界面层
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;
            this.AcceptButton = btn_Login;
            this.CancelButton = btn_Cancel;
        }
        private SysAdminService sysAdminService = new SysAdminService();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            List<SysAdmin> CurrentAdmin = sysAdminService.QuarySysAdmins();
            if (CurrentAdmin.Count > 0)
            {
                foreach (SysAdmin item in CurrentAdmin)
                {
                    this.cmb_User.Items.Add(item.LoginName);
                }
                this.cmb_User.SelectedIndex = 0;

            }
            else
            {
                new FrmMsgNoAck("未查询到数据库包含人员信息", "数据库人员管理").ShowDialog();
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (cmb_User.Text.Trim().Length == 0 || txt_Pwd.Text.Trim().Length == 0)
            {
                new FrmMsgNoAck("账户或密码不能为空", "登陆Tips").ShowDialog();
                return;
            }
            else if (cmb_User.Text.Trim().Length > 0 && txt_Pwd.Text.Trim().Length > 0)
            {
                SysAdmin LoggingUser = new SysAdmin()
                {
                    LoginName = cmb_User.Text,
                    LoginPwd = txt_Pwd.Text,
                };
                LoggingUser = sysAdminService.AdminLogin(LoggingUser);
                if (LoggingUser == null)
                {
                    new FrmMsgNoAck("账户未查到或密码错误", "登陆Tips").ShowDialog();
                    return;
                }
                else
                {
                    Program.CurrentAdmin = LoggingUser;
                    this.DialogResult = DialogResult.OK;
                }

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

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
