using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 加压站SCADA
{
    public partial class MeterControl : UserControl
    {
        public MeterControl()
        {
            InitializeComponent();
        }
        private string paramName = "出水管温度";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量名称")]
        public string ParamName
        {
            get { return paramName; }
            set
            {
                paramName = value;
                this.lbl_ParamName.Text = paramName;
            }
        }
        private float paramValue = 0.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量数值")]
        public float ParamValue
        {
            get { return paramValue; }
            set
            {
                //变化更新
                if (paramValue != value)
                {
                    paramValue = value;
                    this.lbl_ParamValue.Text = paramValue.ToString("f2") + " " + unit;
                }
            }
        }

        private string unit = "℃";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量单位")]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.lbl_ParamValue.Text = paramValue.ToString("f2") + " " + unit;
            }
        }
        private double meterValueMax;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取量程最大值")]
        public double MeterValueMax
        {
            get { return meterValueMax; }
            set { meterValueMax = value;
                this.xbdAnalogMeter1.MaxValue = value;
            }
        }
        private double meterValueMin;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取量程最小值")]
        public double MeterValueMin
        {
            get { return meterValueMin; }
            set
            {
                meterValueMin = value;
                this.xbdAnalogMeter1.MinValue = value;
            }
        }

    }
}
