namespace 加压站SCADA
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_PreTankOut = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.lbl_TempOut = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.lbl_TempIn2 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.lbl_TempIn1 = new System.Windows.Forms.Label();
            this.toggle_PumpIn2 = new xbd.ControlLib.xbdToggle();
            this.toggle_PumpIn1 = new xbd.ControlLib.xbdToggle();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btn_Pump2 = new System.Windows.Forms.Button();
            this.btn_Pump1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.valve_Out = new xbd.ControlLib.xbdValve();
            this.motor_Pump1 = new xbd.ControlLib.xbdMotor();
            this.motor_Pump2 = new xbd.ControlLib.xbdMotor();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.xbdFlowControl10 = new xbd.ControlLib.xbdFlowControl();
            this.xbdFlowControl9 = new xbd.ControlLib.xbdFlowControl();
            this.xbdFlowControl8 = new xbd.ControlLib.xbdFlowControl();
            this.xbdFlowControl7 = new xbd.ControlLib.xbdFlowControl();
            this.xbdFlowControl6 = new xbd.ControlLib.xbdFlowControl();
            this.label28 = new System.Windows.Forms.Label();
            this.pump_In2 = new xbd.ControlLib.xbdPump();
            this.xbdFlowControl5 = new xbd.ControlLib.xbdFlowControl();
            this.xbdFlowControl4 = new xbd.ControlLib.xbdFlowControl();
            this.wave_Tank2 = new xbd.ControlLib.xbdWave();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.xbdFlowControl3 = new xbd.ControlLib.xbdFlowControl();
            this.wave_Tank1 = new xbd.ControlLib.xbdWave();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xbdFlowControl2 = new xbd.ControlLib.xbdFlowControl();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pump_In1 = new xbd.ControlLib.xbdPump();
            this.valve_In = new xbd.ControlLib.xbdValve();
            this.xbdFlowControl1 = new xbd.ControlLib.xbdFlowControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_PressureOut = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_Leveltank1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_Leveltank2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_PressureTank2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_PressureTank1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.led_SysAlarmState = new xbd.ControlLib.xbdState();
            this.label9 = new System.Windows.Forms.Label();
            this.led_SysRunState = new xbd.ControlLib.xbdState();
            this.label8 = new System.Windows.Forms.Label();
            this.led_PlcConnState = new xbd.ControlLib.xbdState();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ms_PressureTank2 = new 加压站SCADA.MeterControl();
            this.ms_PressureTank1 = new 加压站SCADA.MeterControl();
            this.ms_TempOut = new 加压站SCADA.MeterControl();
            this.ms_PressureTankOut = new 加压站SCADA.MeterControl();
            this.ms_TempIn2 = new 加压站SCADA.MeterControl();
            this.ms_TempIn1 = new 加压站SCADA.MeterControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Pressout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.meter_PressureOut = new xbd.ControlLib.xbdAnalogMeter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_PressureIn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.meter_PressureIn = new xbd.ControlLib.xbdAnalogMeter();
            this.xbdFlowControl11 = new xbd.ControlLib.xbdFlowControl();
            this.top_panel = new System.Windows.Forms.Panel();
            this.lbl_DateShow = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ParamSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_ScreenTime = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_PreTankOut);
            this.panel2.Controls.Add(this.label47);
            this.panel2.Controls.Add(this.lbl_TempOut);
            this.panel2.Controls.Add(this.label45);
            this.panel2.Controls.Add(this.lbl_TempIn2);
            this.panel2.Controls.Add(this.label44);
            this.panel2.Controls.Add(this.lbl_TempIn1);
            this.panel2.Controls.Add(this.toggle_PumpIn2);
            this.panel2.Controls.Add(this.toggle_PumpIn1);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Controls.Add(this.btn_Pump2);
            this.panel2.Controls.Add(this.btn_Pump1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label40);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.valve_Out);
            this.panel2.Controls.Add(this.motor_Pump1);
            this.panel2.Controls.Add(this.motor_Pump2);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.xbdFlowControl10);
            this.panel2.Controls.Add(this.xbdFlowControl9);
            this.panel2.Controls.Add(this.xbdFlowControl8);
            this.panel2.Controls.Add(this.xbdFlowControl7);
            this.panel2.Controls.Add(this.xbdFlowControl6);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.pump_In2);
            this.panel2.Controls.Add(this.xbdFlowControl5);
            this.panel2.Controls.Add(this.xbdFlowControl4);
            this.panel2.Controls.Add(this.wave_Tank2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.xbdFlowControl3);
            this.panel2.Controls.Add(this.wave_Tank1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.xbdFlowControl2);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.pump_In1);
            this.panel2.Controls.Add(this.valve_In);
            this.panel2.Controls.Add(this.xbdFlowControl1);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.xbdFlowControl11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 690);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(974, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Bar";
            // 
            // lbl_PreTankOut
            // 
            this.lbl_PreTankOut.AutoSize = true;
            this.lbl_PreTankOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_PreTankOut.ForeColor = System.Drawing.Color.White;
            this.lbl_PreTankOut.Location = new System.Drawing.Point(911, 333);
            this.lbl_PreTankOut.Name = "lbl_PreTankOut";
            this.lbl_PreTankOut.Size = new System.Drawing.Size(71, 29);
            this.lbl_PreTankOut.TabIndex = 60;
            this.lbl_PreTankOut.Text = "00.00";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("楷体", 12F);
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(313, 381);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 20);
            this.label47.TabIndex = 59;
            this.label47.Text = "℃";
            // 
            // lbl_TempOut
            // 
            this.lbl_TempOut.AutoSize = true;
            this.lbl_TempOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_TempOut.ForeColor = System.Drawing.Color.White;
            this.lbl_TempOut.Location = new System.Drawing.Point(250, 375);
            this.lbl_TempOut.Name = "lbl_TempOut";
            this.lbl_TempOut.Size = new System.Drawing.Size(71, 29);
            this.lbl_TempOut.TabIndex = 58;
            this.lbl_TempOut.Text = "00.00";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("楷体", 12F);
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(313, 277);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(29, 20);
            this.label45.TabIndex = 57;
            this.label45.Text = "℃";
            // 
            // lbl_TempIn2
            // 
            this.lbl_TempIn2.AutoSize = true;
            this.lbl_TempIn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_TempIn2.ForeColor = System.Drawing.Color.White;
            this.lbl_TempIn2.Location = new System.Drawing.Point(250, 271);
            this.lbl_TempIn2.Name = "lbl_TempIn2";
            this.lbl_TempIn2.Size = new System.Drawing.Size(71, 29);
            this.lbl_TempIn2.TabIndex = 56;
            this.lbl_TempIn2.Text = "00.00";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("楷体", 12F);
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(313, 118);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(29, 20);
            this.label44.TabIndex = 55;
            this.label44.Text = "℃";
            // 
            // lbl_TempIn1
            // 
            this.lbl_TempIn1.AutoSize = true;
            this.lbl_TempIn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_TempIn1.ForeColor = System.Drawing.Color.White;
            this.lbl_TempIn1.Location = new System.Drawing.Point(252, 112);
            this.lbl_TempIn1.Name = "lbl_TempIn1";
            this.lbl_TempIn1.Size = new System.Drawing.Size(71, 29);
            this.lbl_TempIn1.TabIndex = 54;
            this.lbl_TempIn1.Text = "00.00";
            // 
            // toggle_PumpIn2
            // 
            this.toggle_PumpIn2.Checked = false;
            this.toggle_PumpIn2.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toggle_PumpIn2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggle_PumpIn2.Location = new System.Drawing.Point(343, 271);
            this.toggle_PumpIn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggle_PumpIn2.Name = "toggle_PumpIn2";
            this.toggle_PumpIn2.Size = new System.Drawing.Size(77, 33);
            this.toggle_PumpIn2.SwitchType = xbd.ControlLib.SwitchType.Quadrilateral;
            this.toggle_PumpIn2.TabIndex = 53;
            this.toggle_PumpIn2.Texts = null;
            this.toggle_PumpIn2.TrueColor = System.Drawing.Color.LimeGreen;
            this.toggle_PumpIn2.CheckedChanged += new System.EventHandler(this.toggle_PumpIn2_CheckedChanged);
            // 
            // toggle_PumpIn1
            // 
            this.toggle_PumpIn1.Checked = false;
            this.toggle_PumpIn1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toggle_PumpIn1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toggle_PumpIn1.Location = new System.Drawing.Point(343, 108);
            this.toggle_PumpIn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggle_PumpIn1.Name = "toggle_PumpIn1";
            this.toggle_PumpIn1.Size = new System.Drawing.Size(77, 33);
            this.toggle_PumpIn1.SwitchType = xbd.ControlLib.SwitchType.Quadrilateral;
            this.toggle_PumpIn1.TabIndex = 52;
            this.toggle_PumpIn1.Texts = null;
            this.toggle_PumpIn1.TrueColor = System.Drawing.Color.LimeGreen;
            this.toggle_PumpIn1.CheckedChanged += new System.EventHandler(this.toggle_PumpIn1_CheckedChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(694, 307);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 15);
            this.label42.TabIndex = 50;
            this.label42.Text = "1#循环泵";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(470, 307);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 15);
            this.label41.TabIndex = 49;
            this.label41.Text = "1#循环泵";
            // 
            // btn_Pump2
            // 
            this.btn_Pump2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Pump2.FlatAppearance.BorderSize = 0;
            this.btn_Pump2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pump2.Font = new System.Drawing.Font("楷体", 12F);
            this.btn_Pump2.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Pump2.Image = global::加压站SCADA.Properties.Resources.Border;
            this.btn_Pump2.Location = new System.Drawing.Point(758, 336);
            this.btn_Pump2.Name = "btn_Pump2";
            this.btn_Pump2.Size = new System.Drawing.Size(85, 37);
            this.btn_Pump2.TabIndex = 48;
            this.btn_Pump2.Text = "停止";
            this.btn_Pump2.UseVisualStyleBackColor = true;
            this.btn_Pump2.Click += new System.EventHandler(this.btn_Pump2_Click);
            // 
            // btn_Pump1
            // 
            this.btn_Pump1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Pump1.FlatAppearance.BorderSize = 0;
            this.btn_Pump1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pump1.Font = new System.Drawing.Font("楷体", 12F);
            this.btn_Pump1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Pump1.Image = global::加压站SCADA.Properties.Resources.Border;
            this.btn_Pump1.Location = new System.Drawing.Point(538, 336);
            this.btn_Pump1.Name = "btn_Pump1";
            this.btn_Pump1.Size = new System.Drawing.Size(85, 37);
            this.btn_Pump1.TabIndex = 47;
            this.btn_Pump1.Text = "停止";
            this.btn_Pump1.UseVisualStyleBackColor = true;
            this.btn_Pump1.Click += new System.EventHandler(this.btn_Pump1_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = global::加压站SCADA.Properties.Resources.Border;
            this.button5.Location = new System.Drawing.Point(925, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 37);
            this.button5.TabIndex = 46;
            this.button5.Text = "系统复位";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label40.Location = new System.Drawing.Point(955, 105);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 15);
            this.label40.TabIndex = 45;
            this.label40.Text = "水箱液位";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Image = global::加压站SCADA.Properties.Resources.Border;
            this.button6.Location = new System.Drawing.Point(831, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 37);
            this.button6.TabIndex = 3;
            this.button6.Text = "用户登录";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label39.Location = new System.Drawing.Point(712, 105);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(71, 15);
            this.label39.TabIndex = 44;
            this.label39.Text = "水箱液位";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(798, 105);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(55, 15);
            this.label38.TabIndex = 43;
            this.label38.Text = "2#水箱";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(538, 105);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 15);
            this.label37.TabIndex = 42;
            this.label37.Text = "1#水箱";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label36.Location = new System.Drawing.Point(242, 48);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 15);
            this.label36.TabIndex = 41;
            this.label36.Text = "1#进水管";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label35.Location = new System.Drawing.Point(242, 86);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 15);
            this.label35.TabIndex = 40;
            this.label35.Text = "进水温度";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label34.Location = new System.Drawing.Point(251, 421);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(71, 15);
            this.label34.TabIndex = 39;
            this.label34.Text = "总出水管";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label33.Location = new System.Drawing.Point(251, 347);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 15);
            this.label33.TabIndex = 38;
            this.label33.Text = "出水温度";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label32.Location = new System.Drawing.Point(251, 255);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 15);
            this.label32.TabIndex = 37;
            this.label32.Text = "进水温度";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label31.Location = new System.Drawing.Point(251, 211);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 15);
            this.label31.TabIndex = 36;
            this.label31.Text = "2#进水管";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(357, 347);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 15);
            this.label30.TabIndex = 35;
            this.label30.Text = "出水阀";
            // 
            // valve_Out
            // 
            this.valve_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("valve_Out.BackgroundImage")));
            this.valve_Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.valve_Out.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valve_Out.IsVertical = false;
            this.valve_Out.Location = new System.Drawing.Point(362, 381);
            this.valve_Out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valve_Out.Name = "valve_Out";
            this.valve_Out.Size = new System.Drawing.Size(44, 44);
            this.valve_Out.State = false;
            this.valve_Out.TabIndex = 34;
            this.valve_Out.ValveName = "出水阀";
            this.valve_Out.DoubleClick += new System.EventHandler(this.CommonValveControl);
            // 
            // motor_Pump1
            // 
            this.motor_Pump1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.motor_Pump1.Location = new System.Drawing.Point(468, 323);
            this.motor_Pump1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motor_Pump1.Name = "motor_Pump1";
            this.motor_Pump1.PumpState = xbd.ControlLib.PumpState.停止;
            this.motor_Pump1.Size = new System.Drawing.Size(74, 113);
            this.motor_Pump1.TabIndex = 33;
            // 
            // motor_Pump2
            // 
            this.motor_Pump2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.motor_Pump2.Location = new System.Drawing.Point(692, 323);
            this.motor_Pump2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motor_Pump2.Name = "motor_Pump2";
            this.motor_Pump2.PumpState = xbd.ControlLib.PumpState.停止;
            this.motor_Pump2.Size = new System.Drawing.Size(74, 113);
            this.motor_Pump2.TabIndex = 32;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label29.Location = new System.Drawing.Point(913, 307);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 15);
            this.label29.TabIndex = 31;
            this.label29.Text = "出口压力";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::加压站SCADA.Properties.Resources.Sensor;
            this.pictureBox3.Location = new System.Drawing.Point(925, 375);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // xbdFlowControl10
            // 
            this.xbdFlowControl10.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl10.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xbdFlowControl10.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl10.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl10.Location = new System.Drawing.Point(881, 216);
            this.xbdFlowControl10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl10.MoveSpeed = 0.2F;
            this.xbdFlowControl10.Name = "xbdFlowControl10";
            this.xbdFlowControl10.PipeLineActive = true;
            this.xbdFlowControl10.PipeLineGap = 2;
            this.xbdFlowControl10.PipeLineLength = 2;
            this.xbdFlowControl10.PipeLineStyle = xbd.ControlLib.DirectionStyle.Vertical;
            this.xbdFlowControl10.PipeLineWidth = 5;
            this.xbdFlowControl10.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.Left;
            this.xbdFlowControl10.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Right;
            this.xbdFlowControl10.Size = new System.Drawing.Size(15, 92);
            this.xbdFlowControl10.TabIndex = 29;
            // 
            // xbdFlowControl9
            // 
            this.xbdFlowControl9.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl9.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xbdFlowControl9.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl9.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl9.Location = new System.Drawing.Point(737, 410);
            this.xbdFlowControl9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl9.MoveSpeed = -0.2F;
            this.xbdFlowControl9.Name = "xbdFlowControl9";
            this.xbdFlowControl9.PipeLineActive = true;
            this.xbdFlowControl9.PipeLineGap = 2;
            this.xbdFlowControl9.PipeLineLength = 2;
            this.xbdFlowControl9.PipeLineStyle = xbd.ControlLib.DirectionStyle.Horizontal;
            this.xbdFlowControl9.PipeLineWidth = 5;
            this.xbdFlowControl9.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl9.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Up;
            this.xbdFlowControl9.Size = new System.Drawing.Size(282, 13);
            this.xbdFlowControl9.TabIndex = 28;
            // 
            // xbdFlowControl8
            // 
            this.xbdFlowControl8.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl8.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xbdFlowControl8.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl8.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl8.Location = new System.Drawing.Point(1005, 294);
            this.xbdFlowControl8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl8.MoveSpeed = 0.2F;
            this.xbdFlowControl8.Name = "xbdFlowControl8";
            this.xbdFlowControl8.PipeLineActive = true;
            this.xbdFlowControl8.PipeLineGap = 2;
            this.xbdFlowControl8.PipeLineLength = 2;
            this.xbdFlowControl8.PipeLineStyle = xbd.ControlLib.DirectionStyle.Vertical;
            this.xbdFlowControl8.PipeLineWidth = 5;
            this.xbdFlowControl8.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.Left;
            this.xbdFlowControl8.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl8.Size = new System.Drawing.Size(15, 118);
            this.xbdFlowControl8.TabIndex = 27;
            // 
            // xbdFlowControl7
            // 
            this.xbdFlowControl7.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl7.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xbdFlowControl7.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl7.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl7.Location = new System.Drawing.Point(649, 294);
            this.xbdFlowControl7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl7.MoveSpeed = 0.2F;
            this.xbdFlowControl7.Name = "xbdFlowControl7";
            this.xbdFlowControl7.PipeLineActive = true;
            this.xbdFlowControl7.PipeLineGap = 2;
            this.xbdFlowControl7.PipeLineLength = 2;
            this.xbdFlowControl7.PipeLineStyle = xbd.ControlLib.DirectionStyle.Horizontal;
            this.xbdFlowControl7.PipeLineWidth = 5;
            this.xbdFlowControl7.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl7.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Down;
            this.xbdFlowControl7.Size = new System.Drawing.Size(370, 13);
            this.xbdFlowControl7.TabIndex = 26;
            // 
            // xbdFlowControl6
            // 
            this.xbdFlowControl6.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl6.ColorPipeLineCenter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xbdFlowControl6.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl6.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl6.Location = new System.Drawing.Point(636, 215);
            this.xbdFlowControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl6.MoveSpeed = 0.2F;
            this.xbdFlowControl6.Name = "xbdFlowControl6";
            this.xbdFlowControl6.PipeLineActive = true;
            this.xbdFlowControl6.PipeLineGap = 2;
            this.xbdFlowControl6.PipeLineLength = 2;
            this.xbdFlowControl6.PipeLineStyle = xbd.ControlLib.DirectionStyle.Vertical;
            this.xbdFlowControl6.PipeLineWidth = 5;
            this.xbdFlowControl6.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.Left;
            this.xbdFlowControl6.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Right;
            this.xbdFlowControl6.Size = new System.Drawing.Size(15, 92);
            this.xbdFlowControl6.TabIndex = 25;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(349, 170);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 15);
            this.label28.TabIndex = 24;
            this.label28.Text = "2#进水泵";
            // 
            // pump_In2
            // 
            this.pump_In2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.pump_In2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.pump_In2.Color2 = System.Drawing.Color.LightGray;
            this.pump_In2.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(135)))), ((int)(((byte)(69)))));
            this.pump_In2.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.pump_In2.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.pump_In2.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.pump_In2.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.pump_In2.Export = 6;
            this.pump_In2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pump_In2.IsRun = false;
            this.pump_In2.Location = new System.Drawing.Point(338, 178);
            this.pump_In2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pump_In2.MoveSpeed = 1F;
            this.pump_In2.Name = "pump_In2";
            this.pump_In2.Size = new System.Drawing.Size(92, 89);
            this.pump_In2.TabIndex = 23;
            this.pump_In2.Text = "pump_In2";
            // 
            // xbdFlowControl5
            // 
            this.xbdFlowControl5.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl5.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.xbdFlowControl5.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl5.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl5.Location = new System.Drawing.Point(453, 68);
            this.xbdFlowControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl5.MoveSpeed = 0.2F;
            this.xbdFlowControl5.Name = "xbdFlowControl5";
            this.xbdFlowControl5.PipeLineActive = true;
            this.xbdFlowControl5.PipeLineGap = 2;
            this.xbdFlowControl5.PipeLineLength = 2;
            this.xbdFlowControl5.PipeLineStyle = xbd.ControlLib.DirectionStyle.Vertical;
            this.xbdFlowControl5.PipeLineWidth = 5;
            this.xbdFlowControl5.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.Left;
            this.xbdFlowControl5.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Left;
            this.xbdFlowControl5.Size = new System.Drawing.Size(15, 180);
            this.xbdFlowControl5.TabIndex = 22;
            // 
            // xbdFlowControl4
            // 
            this.xbdFlowControl4.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl4.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.xbdFlowControl4.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl4.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl4.Location = new System.Drawing.Point(236, 231);
            this.xbdFlowControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl4.MoveSpeed = -0.2F;
            this.xbdFlowControl4.Name = "xbdFlowControl4";
            this.xbdFlowControl4.PipeLineActive = true;
            this.xbdFlowControl4.PipeLineGap = 2;
            this.xbdFlowControl4.PipeLineLength = 2;
            this.xbdFlowControl4.PipeLineStyle = xbd.ControlLib.DirectionStyle.Horizontal;
            this.xbdFlowControl4.PipeLineWidth = 5;
            this.xbdFlowControl4.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.Left;
            this.xbdFlowControl4.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl4.Size = new System.Drawing.Size(223, 21);
            this.xbdFlowControl4.TabIndex = 21;
            // 
            // wave_Tank2
            // 
            this.wave_Tank2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.wave_Tank2.ConerRadius = 10;
            this.wave_Tank2.FillColor = System.Drawing.Color.Transparent;
            this.wave_Tank2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wave_Tank2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wave_Tank2.IsRadius = true;
            this.wave_Tank2.IsRectangle = true;
            this.wave_Tank2.IsShowRect = false;
            this.wave_Tank2.Location = new System.Drawing.Point(963, 125);
            this.wave_Tank2.MaxValue = 100;
            this.wave_Tank2.Name = "wave_Tank2";
            this.wave_Tank2.RectColor = System.Drawing.Color.White;
            this.wave_Tank2.RectWidth = 4;
            this.wave_Tank2.Size = new System.Drawing.Size(56, 107);
            this.wave_Tank2.TabIndex = 20;
            this.wave_Tank2.Value = 0;
            this.wave_Tank2.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::加压站SCADA.Properties.Resources.Tank;
            this.pictureBox2.Location = new System.Drawing.Point(771, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // xbdFlowControl3
            // 
            this.xbdFlowControl3.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl3.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.xbdFlowControl3.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl3.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl3.Location = new System.Drawing.Point(851, 87);
            this.xbdFlowControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl3.MoveSpeed = 0.2F;
            this.xbdFlowControl3.Name = "xbdFlowControl3";
            this.xbdFlowControl3.PipeLineActive = true;
            this.xbdFlowControl3.PipeLineGap = 2;
            this.xbdFlowControl3.PipeLineLength = 2;
            this.xbdFlowControl3.PipeLineStyle = xbd.ControlLib.DirectionStyle.Vertical;
            this.xbdFlowControl3.PipeLineWidth = 5;
            this.xbdFlowControl3.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl3.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Down;
            this.xbdFlowControl3.Size = new System.Drawing.Size(27, 73);
            this.xbdFlowControl3.TabIndex = 18;
            // 
            // wave_Tank1
            // 
            this.wave_Tank1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.wave_Tank1.ConerRadius = 10;
            this.wave_Tank1.FillColor = System.Drawing.Color.Transparent;
            this.wave_Tank1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wave_Tank1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wave_Tank1.IsRadius = true;
            this.wave_Tank1.IsRectangle = true;
            this.wave_Tank1.IsShowRect = false;
            this.wave_Tank1.Location = new System.Drawing.Point(721, 125);
            this.wave_Tank1.MaxValue = 100;
            this.wave_Tank1.Name = "wave_Tank1";
            this.wave_Tank1.RectColor = System.Drawing.Color.White;
            this.wave_Tank1.RectWidth = 4;
            this.wave_Tank1.Size = new System.Drawing.Size(56, 107);
            this.wave_Tank1.TabIndex = 17;
            this.wave_Tank1.Value = 34;
            this.wave_Tank1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::加压站SCADA.Properties.Resources.Tank;
            this.pictureBox1.Location = new System.Drawing.Point(529, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // xbdFlowControl2
            // 
            this.xbdFlowControl2.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl2.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.xbdFlowControl2.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl2.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl2.Location = new System.Drawing.Point(616, 67);
            this.xbdFlowControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl2.MoveSpeed = 0.2F;
            this.xbdFlowControl2.Name = "xbdFlowControl2";
            this.xbdFlowControl2.PipeLineActive = true;
            this.xbdFlowControl2.PipeLineGap = 2;
            this.xbdFlowControl2.PipeLineLength = 2;
            this.xbdFlowControl2.PipeLineStyle = xbd.ControlLib.DirectionStyle.Vertical;
            this.xbdFlowControl2.PipeLineWidth = 5;
            this.xbdFlowControl2.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.Left;
            this.xbdFlowControl2.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl2.Size = new System.Drawing.Size(15, 92);
            this.xbdFlowControl2.TabIndex = 15;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(516, 7);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 15);
            this.label27.TabIndex = 14;
            this.label27.Text = "1#进水阀";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(349, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 15);
            this.label26.TabIndex = 13;
            this.label26.Text = "1#进水泵";
            // 
            // pump_In1
            // 
            this.pump_In1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.pump_In1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(227)))));
            this.pump_In1.Color2 = System.Drawing.Color.LightGray;
            this.pump_In1.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(135)))), ((int)(((byte)(69)))));
            this.pump_In1.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.pump_In1.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(220)))));
            this.pump_In1.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(160)))), ((int)(((byte)(169)))));
            this.pump_In1.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.pump_In1.Export = 6;
            this.pump_In1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pump_In1.IsRun = false;
            this.pump_In1.Location = new System.Drawing.Point(338, 15);
            this.pump_In1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pump_In1.MoveSpeed = 1F;
            this.pump_In1.Name = "pump_In1";
            this.pump_In1.Size = new System.Drawing.Size(92, 89);
            this.pump_In1.TabIndex = 12;
            this.pump_In1.Text = "xbdPump1";
            // 
            // valve_In
            // 
            this.valve_In.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("valve_In.BackgroundImage")));
            this.valve_In.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.valve_In.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.valve_In.IsVertical = false;
            this.valve_In.Location = new System.Drawing.Point(529, 39);
            this.valve_In.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valve_In.Name = "valve_In";
            this.valve_In.Size = new System.Drawing.Size(44, 44);
            this.valve_In.State = false;
            this.valve_In.TabIndex = 11;
            this.valve_In.ValveName = "进水阀";
            this.valve_In.Load += new System.EventHandler(this.valve_In_Load);
            this.valve_In.DoubleClick += new System.EventHandler(this.CommonValveControl);
            // 
            // xbdFlowControl1
            // 
            this.xbdFlowControl1.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl1.ColorPipeLineCenter = System.Drawing.Color.DodgerBlue;
            this.xbdFlowControl1.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl1.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl1.Location = new System.Drawing.Point(236, 68);
            this.xbdFlowControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl1.MoveSpeed = 0.2F;
            this.xbdFlowControl1.Name = "xbdFlowControl1";
            this.xbdFlowControl1.PipeLineActive = true;
            this.xbdFlowControl1.PipeLineGap = 2;
            this.xbdFlowControl1.PipeLineLength = 2;
            this.xbdFlowControl1.PipeLineStyle = xbd.ControlLib.DirectionStyle.Horizontal;
            this.xbdFlowControl1.PipeLineWidth = 5;
            this.xbdFlowControl1.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl1.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Down;
            this.xbdFlowControl1.Size = new System.Drawing.Size(629, 13);
            this.xbdFlowControl1.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::加压站SCADA.Properties.Resources.ParamPanel;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(967, 442);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(273, 195);
            this.panel7.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::加压站SCADA.Properties.Resources.ParamPanel;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.lbl_PressureOut);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.lbl_Leveltank1);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.lbl_Leveltank2);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.lbl_PressureTank2);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lbl_PressureTank1);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(1030, 191);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 245);
            this.panel6.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("楷体", 10F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(160, 204);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 17);
            this.label23.TabIndex = 16;
            this.label23.Text = "Bar";
            // 
            // lbl_PressureOut
            // 
            this.lbl_PressureOut.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PressureOut.Font = new System.Drawing.Font("楷体", 10F);
            this.lbl_PressureOut.ForeColor = System.Drawing.Color.White;
            this.lbl_PressureOut.Location = new System.Drawing.Point(113, 204);
            this.lbl_PressureOut.Name = "lbl_PressureOut";
            this.lbl_PressureOut.Size = new System.Drawing.Size(53, 17);
            this.lbl_PressureOut.TabIndex = 15;
            this.lbl_PressureOut.Text = "0.00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("楷体", 10F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(13, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 17);
            this.label25.TabIndex = 14;
            this.label25.Text = "出水管压力";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("楷体", 10F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(160, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "m";
            // 
            // lbl_Leveltank1
            // 
            this.lbl_Leveltank1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Leveltank1.Font = new System.Drawing.Font("楷体", 10F);
            this.lbl_Leveltank1.ForeColor = System.Drawing.Color.White;
            this.lbl_Leveltank1.Location = new System.Drawing.Point(113, 81);
            this.lbl_Leveltank1.Name = "lbl_Leveltank1";
            this.lbl_Leveltank1.Size = new System.Drawing.Size(53, 17);
            this.lbl_Leveltank1.TabIndex = 12;
            this.lbl_Leveltank1.Text = "0.00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("楷体", 10F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(15, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "1#水箱液位";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("楷体", 10F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(160, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "m";
            // 
            // lbl_Leveltank2
            // 
            this.lbl_Leveltank2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Leveltank2.Font = new System.Drawing.Font("楷体", 10F);
            this.lbl_Leveltank2.ForeColor = System.Drawing.Color.White;
            this.lbl_Leveltank2.Location = new System.Drawing.Point(113, 163);
            this.lbl_Leveltank2.Name = "lbl_Leveltank2";
            this.lbl_Leveltank2.Size = new System.Drawing.Size(53, 17);
            this.lbl_Leveltank2.TabIndex = 9;
            this.lbl_Leveltank2.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("楷体", 10F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(13, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "2#水箱液位";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("楷体", 10F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(160, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Bar";
            // 
            // lbl_PressureTank2
            // 
            this.lbl_PressureTank2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PressureTank2.Font = new System.Drawing.Font("楷体", 10F);
            this.lbl_PressureTank2.ForeColor = System.Drawing.Color.White;
            this.lbl_PressureTank2.Location = new System.Drawing.Point(113, 122);
            this.lbl_PressureTank2.Name = "lbl_PressureTank2";
            this.lbl_PressureTank2.Size = new System.Drawing.Size(53, 17);
            this.lbl_PressureTank2.TabIndex = 6;
            this.lbl_PressureTank2.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("楷体", 10F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "2#水箱压力";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("楷体", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(160, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Bar";
            // 
            // lbl_PressureTank1
            // 
            this.lbl_PressureTank1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PressureTank1.Font = new System.Drawing.Font("楷体", 10F);
            this.lbl_PressureTank1.ForeColor = System.Drawing.Color.White;
            this.lbl_PressureTank1.Location = new System.Drawing.Point(113, 40);
            this.lbl_PressureTank1.Name = "lbl_PressureTank1";
            this.lbl_PressureTank1.Size = new System.Drawing.Size(53, 17);
            this.lbl_PressureTank1.TabIndex = 3;
            this.lbl_PressureTank1.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("楷体", 10F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "1#水箱压力";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("楷体", 10F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(15, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "系统状态";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::加压站SCADA.Properties.Resources.ParamPanel;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.led_SysAlarmState);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.led_SysRunState);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.led_PlcConnState);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(1030, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 155);
            this.panel5.TabIndex = 4;
            // 
            // led_SysAlarmState
            // 
            this.led_SysAlarmState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("led_SysAlarmState.BackgroundImage")));
            this.led_SysAlarmState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.led_SysAlarmState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_SysAlarmState.Location = new System.Drawing.Point(152, 115);
            this.led_SysAlarmState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.led_SysAlarmState.Name = "led_SysAlarmState";
            this.led_SysAlarmState.Size = new System.Drawing.Size(24, 24);
            this.led_SysAlarmState.State = false;
            this.led_SysAlarmState.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("楷体", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "系统报警状态";
            // 
            // led_SysRunState
            // 
            this.led_SysRunState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("led_SysRunState.BackgroundImage")));
            this.led_SysRunState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.led_SysRunState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_SysRunState.Location = new System.Drawing.Point(152, 75);
            this.led_SysRunState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.led_SysRunState.Name = "led_SysRunState";
            this.led_SysRunState.Size = new System.Drawing.Size(24, 24);
            this.led_SysRunState.State = false;
            this.led_SysRunState.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("楷体", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "系统运行状态";
            // 
            // led_PlcConnState
            // 
            this.led_PlcConnState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("led_PlcConnState.BackgroundImage")));
            this.led_PlcConnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.led_PlcConnState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.led_PlcConnState.Location = new System.Drawing.Point(152, 35);
            this.led_PlcConnState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.led_PlcConnState.Name = "led_PlcConnState";
            this.led_PlcConnState.Size = new System.Drawing.Size(24, 24);
            this.led_PlcConnState.State = false;
            this.led_PlcConnState.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "PLC连接状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("楷体", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(15, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "系统状态";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::加压站SCADA.Properties.Resources.DataPanel;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.ms_PressureTank2);
            this.panel4.Controls.Add(this.ms_PressureTank1);
            this.panel4.Controls.Add(this.ms_TempOut);
            this.panel4.Controls.Add(this.ms_PressureTankOut);
            this.panel4.Controls.Add(this.ms_TempIn2);
            this.panel4.Controls.Add(this.ms_TempIn1);
            this.panel4.Location = new System.Drawing.Point(19, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 200);
            this.panel4.TabIndex = 5;
            // 
            // ms_PressureTank2
            // 
            this.ms_PressureTank2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.ms_PressureTank2.Location = new System.Drawing.Point(620, 15);
            this.ms_PressureTank2.MeterValueMax = 10D;
            this.ms_PressureTank2.MeterValueMin = 0D;
            this.ms_PressureTank2.Name = "ms_PressureTank2";
            this.ms_PressureTank2.ParamName = "2#水箱压力";
            this.ms_PressureTank2.ParamValue = 0F;
            this.ms_PressureTank2.Size = new System.Drawing.Size(150, 170);
            this.ms_PressureTank2.TabIndex = 5;
            this.ms_PressureTank2.Unit = "Bar";
            // 
            // ms_PressureTank1
            // 
            this.ms_PressureTank1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.ms_PressureTank1.Location = new System.Drawing.Point(468, 15);
            this.ms_PressureTank1.MeterValueMax = 10D;
            this.ms_PressureTank1.MeterValueMin = 0D;
            this.ms_PressureTank1.Name = "ms_PressureTank1";
            this.ms_PressureTank1.ParamName = "1#水箱压力";
            this.ms_PressureTank1.ParamValue = 0F;
            this.ms_PressureTank1.Size = new System.Drawing.Size(150, 170);
            this.ms_PressureTank1.TabIndex = 4;
            this.ms_PressureTank1.Unit = "Bar";
            // 
            // ms_TempOut
            // 
            this.ms_TempOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.ms_TempOut.Location = new System.Drawing.Point(316, 15);
            this.ms_TempOut.MeterValueMax = 10D;
            this.ms_TempOut.MeterValueMin = 0D;
            this.ms_TempOut.Name = "ms_TempOut";
            this.ms_TempOut.ParamName = "出水管温度";
            this.ms_TempOut.ParamValue = 0F;
            this.ms_TempOut.Size = new System.Drawing.Size(150, 170);
            this.ms_TempOut.TabIndex = 3;
            this.ms_TempOut.Unit = "℃";
            // 
            // ms_PressureTankOut
            // 
            this.ms_PressureTankOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.ms_PressureTankOut.Location = new System.Drawing.Point(772, 15);
            this.ms_PressureTankOut.MeterValueMax = 10D;
            this.ms_PressureTankOut.MeterValueMin = 0D;
            this.ms_PressureTankOut.Name = "ms_PressureTankOut";
            this.ms_PressureTankOut.ParamName = "水箱出口压力";
            this.ms_PressureTankOut.ParamValue = 0F;
            this.ms_PressureTankOut.Size = new System.Drawing.Size(150, 170);
            this.ms_PressureTankOut.TabIndex = 2;
            this.ms_PressureTankOut.Unit = "Bar";
            // 
            // ms_TempIn2
            // 
            this.ms_TempIn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.ms_TempIn2.Location = new System.Drawing.Point(164, 15);
            this.ms_TempIn2.MeterValueMax = 10D;
            this.ms_TempIn2.MeterValueMin = 0D;
            this.ms_TempIn2.Name = "ms_TempIn2";
            this.ms_TempIn2.ParamName = "2#进水管温度";
            this.ms_TempIn2.ParamValue = 0F;
            this.ms_TempIn2.Size = new System.Drawing.Size(150, 170);
            this.ms_TempIn2.TabIndex = 1;
            this.ms_TempIn2.Unit = "℃";
            // 
            // ms_TempIn1
            // 
            this.ms_TempIn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.ms_TempIn1.Location = new System.Drawing.Point(12, 15);
            this.ms_TempIn1.MeterValueMax = 10D;
            this.ms_TempIn1.MeterValueMin = 0D;
            this.ms_TempIn1.Name = "ms_TempIn1";
            this.ms_TempIn1.ParamName = "1#进水管温度";
            this.ms_TempIn1.ParamValue = 3F;
            this.ms_TempIn1.Size = new System.Drawing.Size(150, 170);
            this.ms_TempIn1.TabIndex = 0;
            this.ms_TempIn1.Unit = "℃";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::加压站SCADA.Properties.Resources.ParamPanel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbl_Pressout);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.meter_PressureOut);
            this.panel3.Location = new System.Drawing.Point(19, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 200);
            this.panel3.TabIndex = 4;
            // 
            // lbl_Pressout
            // 
            this.lbl_Pressout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Pressout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Pressout.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_Pressout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Pressout.Location = new System.Drawing.Point(53, 144);
            this.lbl_Pressout.Name = "lbl_Pressout";
            this.lbl_Pressout.Size = new System.Drawing.Size(103, 37);
            this.lbl_Pressout.TabIndex = 3;
            this.lbl_Pressout.Text = "0.00 Bar";
            this.lbl_Pressout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(15, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "出水压力";
            // 
            // meter_PressureOut
            // 
            this.meter_PressureOut.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.meter_PressureOut.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_PressureOut.Location = new System.Drawing.Point(18, 5);
            this.meter_PressureOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_PressureOut.MaxValue = 10D;
            this.meter_PressureOut.MinValue = 0D;
            this.meter_PressureOut.Name = "meter_PressureOut";
            this.meter_PressureOut.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.meter_PressureOut.Renderer = null;
            this.meter_PressureOut.ScaleColor = System.Drawing.Color.White;
            this.meter_PressureOut.ScaleDivisions = 11;
            this.meter_PressureOut.ScaleSubDivisions = 4;
            this.meter_PressureOut.Size = new System.Drawing.Size(176, 176);
            this.meter_PressureOut.TabIndex = 0;
            this.meter_PressureOut.Value = 0D;
            this.meter_PressureOut.ViewGlass = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::加压站SCADA.Properties.Resources.ParamPanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_PressureIn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.meter_PressureIn);
            this.panel1.Location = new System.Drawing.Point(19, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 200);
            this.panel1.TabIndex = 0;
            // 
            // lbl_PressureIn
            // 
            this.lbl_PressureIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_PressureIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_PressureIn.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_PressureIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_PressureIn.Location = new System.Drawing.Point(53, 144);
            this.lbl_PressureIn.Name = "lbl_PressureIn";
            this.lbl_PressureIn.Size = new System.Drawing.Size(103, 37);
            this.lbl_PressureIn.TabIndex = 3;
            this.lbl_PressureIn.Text = "0.00 Bar";
            this.lbl_PressureIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(15, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "进水压力";
            // 
            // meter_PressureIn
            // 
            this.meter_PressureIn.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.meter_PressureIn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_PressureIn.Location = new System.Drawing.Point(18, 5);
            this.meter_PressureIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_PressureIn.MaxValue = 10D;
            this.meter_PressureIn.MinValue = 0D;
            this.meter_PressureIn.Name = "meter_PressureIn";
            this.meter_PressureIn.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.meter_PressureIn.Renderer = null;
            this.meter_PressureIn.ScaleColor = System.Drawing.Color.White;
            this.meter_PressureIn.ScaleDivisions = 11;
            this.meter_PressureIn.ScaleSubDivisions = 4;
            this.meter_PressureIn.Size = new System.Drawing.Size(176, 176);
            this.meter_PressureIn.TabIndex = 0;
            this.meter_PressureIn.Value = 0D;
            this.meter_PressureIn.ViewGlass = false;
            // 
            // xbdFlowControl11
            // 
            this.xbdFlowControl11.BackColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl11.ColorPipeLineCenter = System.Drawing.Color.DarkTurquoise;
            this.xbdFlowControl11.EdgeColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdFlowControl11.LineCenterColor = System.Drawing.Color.Transparent;
            this.xbdFlowControl11.Location = new System.Drawing.Point(236, 410);
            this.xbdFlowControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdFlowControl11.MoveSpeed = -0.2F;
            this.xbdFlowControl11.Name = "xbdFlowControl11";
            this.xbdFlowControl11.PipeLineActive = true;
            this.xbdFlowControl11.PipeLineGap = 2;
            this.xbdFlowControl11.PipeLineLength = 2;
            this.xbdFlowControl11.PipeLineStyle = xbd.ControlLib.DirectionStyle.Horizontal;
            this.xbdFlowControl11.PipeLineWidth = 5;
            this.xbdFlowControl11.PipeTurnLeft = xbd.ControlLib.PipeTurnDirection.None;
            this.xbdFlowControl11.PipeTurnRight = xbd.ControlLib.PipeTurnDirection.Up;
            this.xbdFlowControl11.Size = new System.Drawing.Size(493, 13);
            this.xbdFlowControl11.TabIndex = 51;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.top_panel.BackgroundImage = global::加压站SCADA.Properties.Resources.TopPanel;
            this.top_panel.Controls.Add(this.lbl_DateShow);
            this.top_panel.Controls.Add(this.button4);
            this.top_panel.Controls.Add(this.button3);
            this.top_panel.Controls.Add(this.button2);
            this.top_panel.Controls.Add(this.btn_ParamSet);
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1271, 83);
            this.top_panel.TabIndex = 0;
            // 
            // lbl_DateShow
            // 
            this.lbl_DateShow.AutoSize = true;
            this.lbl_DateShow.ForeColor = System.Drawing.Color.White;
            this.lbl_DateShow.Location = new System.Drawing.Point(828, 63);
            this.lbl_DateShow.Name = "lbl_DateShow";
            this.lbl_DateShow.Size = new System.Drawing.Size(215, 15);
            this.lbl_DateShow.TabIndex = 0;
            this.lbl_DateShow.Text = "2026-01-01 00:00:00 星期一";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = global::加压站SCADA.Properties.Resources.Border;
            this.button4.Location = new System.Drawing.Point(1166, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "退出系统";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::加压站SCADA.Properties.Resources.Border;
            this.button3.Location = new System.Drawing.Point(1061, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "用户登录";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::加压站SCADA.Properties.Resources.Border;
            this.button2.Location = new System.Drawing.Point(120, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "历史记录";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_ParamSet
            // 
            this.btn_ParamSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ParamSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ParamSet.FlatAppearance.BorderSize = 0;
            this.btn_ParamSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ParamSet.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ParamSet.Image = global::加压站SCADA.Properties.Resources.Border;
            this.btn_ParamSet.Location = new System.Drawing.Point(15, 12);
            this.btn_ParamSet.Name = "btn_ParamSet";
            this.btn_ParamSet.Size = new System.Drawing.Size(99, 42);
            this.btn_ParamSet.TabIndex = 1;
            this.btn_ParamSet.Text = "参数设置";
            this.btn_ParamSet.UseVisualStyleBackColor = true;
            this.btn_ParamSet.Click += new System.EventHandler(this.btn_ParamSet_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(446, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "智慧加压站SCADA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_ScreenTime
            // 
            this.timer_ScreenTime.Interval = 500;
//            this.timer_ScreenTime.Tick += new System.EventHandler(this.timer_ScreenTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 773);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ParamSet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_DateShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private xbd.ControlLib.xbdAnalogMeter meter_PressureIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Pressout;
        private System.Windows.Forms.Label label5;
        private xbd.ControlLib.xbdAnalogMeter meter_PressureOut;
        private System.Windows.Forms.Label lbl_PressureIn;
        private System.Windows.Forms.Panel panel4;
        private MeterControl ms_PressureTank2;
        private MeterControl ms_PressureTank1;
        private MeterControl ms_TempOut;
        private MeterControl ms_PressureTankOut;
        private MeterControl ms_TempIn2;
        private MeterControl ms_TempIn1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_PressureOut;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_Leveltank1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_Leveltank2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_PressureTank2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_PressureTank1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private xbd.ControlLib.xbdState led_SysAlarmState;
        private System.Windows.Forms.Label label9;
        private xbd.ControlLib.xbdState led_SysRunState;
        private System.Windows.Forms.Label label8;
        private xbd.ControlLib.xbdState led_PlcConnState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private xbd.ControlLib.xbdPump pump_In1;
        private xbd.ControlLib.xbdValve valve_In;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl1;
        private xbd.ControlLib.xbdWave wave_Tank2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl3;
        private xbd.ControlLib.xbdWave wave_Tank1;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl10;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl9;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl8;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl7;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl6;
        private System.Windows.Forms.Label label28;
        private xbd.ControlLib.xbdPump pump_In2;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl5;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private xbd.ControlLib.xbdValve valve_Out;
        private xbd.ControlLib.xbdMotor motor_Pump1;
        private xbd.ControlLib.xbdMotor motor_Pump2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btn_Pump2;
        private System.Windows.Forms.Button btn_Pump1;
        private xbd.ControlLib.xbdToggle toggle_PumpIn2;
        private xbd.ControlLib.xbdToggle toggle_PumpIn1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private xbd.ControlLib.xbdFlowControl xbdFlowControl11;
        private System.Windows.Forms.Label lbl_TempIn1;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label lbl_TempOut;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label lbl_TempIn2;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_PreTankOut;
        private System.Windows.Forms.Timer timer_ScreenTime;
        //private MeterControl meterControl1;
    }
}

