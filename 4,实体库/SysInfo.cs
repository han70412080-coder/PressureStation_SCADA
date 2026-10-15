using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbd.s7netplus;

namespace 加压站SCADA
{
    public class SysInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string IPAddress { get; set; }
        /// <summary>
        /// Cpu类型
        /// </summary>
        public CpuType CpuType { get; set; }
        /// <summary>
        /// 机架号
        /// </summary>
        public short Rack { get; set; }
        /// <summary>
        /// 插槽号
        /// </summary>
        public short Slot { get; set; }


        /// <summary>
        /// 开机自启动
        /// </summary>
        public bool AutoStart { get; set; }

        public int ScreenTime { get; set; }
        /// <summary>
        /// 注销时间
        /// </summary>
        public int LogoutTime { get; set; }

        public int CameraIndex { get; set; }
    }
}
