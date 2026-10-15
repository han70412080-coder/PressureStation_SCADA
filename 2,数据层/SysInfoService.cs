using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.s7netplus;

namespace 加压站SCADA
{
    public class SysInfoService
    {
        /// <summary>
        /// 通过对象获取参数
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public SysInfo GetSysInfoFromPath(string path)
        {
            try
            {
                SysInfo sysInfo = new SysInfo();
                sysInfo.IPAddress = IniConfigHelper.ReadIniData("配置参数", "IP地址", "127.0.0.1", path);
                sysInfo.CpuType = (CpuType)Enum.Parse(typeof(CpuType), IniConfigHelper.ReadIniData("配置参数", "Cpu类型", "200smart", path), true);
                sysInfo.Rack = Convert.ToInt16(IniConfigHelper.ReadIniData("配置参数", "机架号", "0", path));
                sysInfo.Slot = Convert.ToInt16(IniConfigHelper.ReadIniData("配置参数", "插槽号", "0", path));

                sysInfo.AutoStart = IniConfigHelper.ReadIniData("系统参数", "开机自启动", "0", path) == "True";
                sysInfo.ScreenTime = Convert.ToInt32(IniConfigHelper.ReadIniData("系统参数", "自动息屏时间", "0", path));
                sysInfo.LogoutTime = Convert.ToInt32(IniConfigHelper.ReadIniData("系统参数", "自动注销时间", "0", path));
                sysInfo.CameraIndex = Convert.ToInt32(IniConfigHelper.ReadIniData("系统参数", "相机序号", "0", path));
                return sysInfo;
            }
            catch (Exception)
            {
                return null;
            }


        }
        /// <summary>
        /// 写入Ini配置，成功true，失败false
        /// </summary>
        /// <returns></returns>
        public bool SetSysInfoToPath(SysInfo sysInfo, string path)
        {
            bool reslut = true;
            reslut &= IniConfigHelper.WriteIniData("配置参数", "IP地址", sysInfo.IPAddress, path);
            reslut &= IniConfigHelper.WriteIniData("配置参数", "Cpu类型", sysInfo.CpuType.ToString(), path);
            reslut &= IniConfigHelper.WriteIniData("配置参数", "机架号", sysInfo.Rack.ToString(), path);
            reslut &= IniConfigHelper.WriteIniData("配置参数", "插槽号", sysInfo.Slot.ToString(), path);

            reslut &= IniConfigHelper.WriteIniData("系统参数", "开机自启动", sysInfo.AutoStart.ToString(), path);
            reslut &= IniConfigHelper.WriteIniData("系统参数", "自动息屏时间", sysInfo.ScreenTime.ToString(), path);
            reslut &= IniConfigHelper.WriteIniData("系统参数", "自动注销时间", sysInfo.LogoutTime.ToString(), path);
            reslut &= IniConfigHelper.WriteIniData("系统参数", "相机序号", sysInfo.CameraIndex.ToString(), path);

            return reslut;
        }
    }
}
