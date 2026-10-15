namespace 加压站SCADA
{
    partial class MeterControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ParamName = new System.Windows.Forms.Label();
            this.lbl_ParamValue = new System.Windows.Forms.Label();
            this.xbdAnalogMeter1 = new xbd.ControlLib.xbdAnalogMeter();
            this.SuspendLayout();
            // 
            // lbl_ParamName
            // 
            this.lbl_ParamName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_ParamName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ParamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_ParamName.Location = new System.Drawing.Point(0, 147);
            this.lbl_ParamName.Name = "lbl_ParamName";
            this.lbl_ParamName.Size = new System.Drawing.Size(150, 23);
            this.lbl_ParamName.TabIndex = 1;
            this.lbl_ParamName.Text = "进水管温度";
            this.lbl_ParamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ParamValue
            // 
            this.lbl_ParamValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ParamValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ParamValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ParamValue.Location = new System.Drawing.Point(29, 116);
            this.lbl_ParamValue.Name = "lbl_ParamValue";
            this.lbl_ParamValue.Size = new System.Drawing.Size(87, 23);
            this.lbl_ParamValue.TabIndex = 2;
            this.lbl_ParamValue.Text = "0.00 ℃";
            this.lbl_ParamValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xbdAnalogMeter1
            // 
            this.xbdAnalogMeter1.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.xbdAnalogMeter1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xbdAnalogMeter1.Location = new System.Drawing.Point(1, -1);
            this.xbdAnalogMeter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xbdAnalogMeter1.MaxValue = 100D;
            this.xbdAnalogMeter1.MinValue = 0D;
            this.xbdAnalogMeter1.Name = "xbdAnalogMeter1";
            this.xbdAnalogMeter1.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.xbdAnalogMeter1.Renderer = null;
            this.xbdAnalogMeter1.ScaleColor = System.Drawing.Color.White;
            this.xbdAnalogMeter1.ScaleDivisions = 11;
            this.xbdAnalogMeter1.ScaleSubDivisions = 4;
            this.xbdAnalogMeter1.Size = new System.Drawing.Size(145, 143);
            this.xbdAnalogMeter1.TabIndex = 0;
            this.xbdAnalogMeter1.Value = 0D;
            this.xbdAnalogMeter1.ViewGlass = false;
            // 
            // MeterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.lbl_ParamValue);
            this.Controls.Add(this.lbl_ParamName);
            this.Controls.Add(this.xbdAnalogMeter1);
            this.Name = "MeterControl";
            this.Size = new System.Drawing.Size(150, 170);
            this.ResumeLayout(false);

        }

        #endregion

        private xbd.ControlLib.xbdAnalogMeter xbdAnalogMeter1;
        private System.Windows.Forms.Label lbl_ParamName;
        private System.Windows.Forms.Label lbl_ParamValue;
    }
}
