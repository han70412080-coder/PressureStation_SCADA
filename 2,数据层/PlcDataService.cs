using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using xbd.DataConvertLib;

namespace 加压站SCADA
{
    public class PlcDataService

    {
        public bool IsConnected { get; set; }

        S7NetLib s7NetLib;
        /// <summary>
        /// 根据SysInfo=界面参数设置里CPUType，IPAddress等调用封装的s7NetLib方法中底层xbd.s7netplus
        /// 进行链接
        /// </summary>
        /// <param name="sysInfo"></param>
        /// <returns></returns>
        public OperateResult Connect(SysInfo sysInfo)
        {
            try
            {
                DisConnect();
            }
            catch (Exception)
            {

            }
            s7NetLib = new S7NetLib(sysInfo.CpuType, sysInfo.IPAddress, sysInfo.Rack, sysInfo.Slot);
            OperateResult operateResult= s7NetLib.Connect();
            this.IsConnected = operateResult.IsSuccess;
            return operateResult;
        }
        public OperateResult DisConnect()
        {
            if (s7NetLib!=null)
            {
                return s7NetLib.DisConnect();
            }
            else
            {
                return OperateResult.CreateFailResult();
            }
        }
        /// <summary>
        /// 通过封装的s7netLib方法调用ReadByByteArray方法，返回PlcData数据对象
        /// </summary>
        /// <returns>PlcData数据实例对象</returns>
        public OperateResult<PlcData> ReadPlcData()
        {
            //封装的s7netLib方法
            int resultLength = 44;
            var result = s7NetLib.ReadByByteArray(xbd.s7netplus.DataType.DataBlock,1,0, resultLength);
            if (result.IsSuccess&&result.Content.Length== resultLength)
            {
                PlcData plcData = new PlcData();
                plcData.InPump1State = BitLib.GetBitFromByteArray(result.Content, 0, 0);
                plcData.InPump2State = BitLib.GetBitFromByteArray(result.Content, 0, 1);
                plcData.CirclePump1State = BitLib.GetBitFromByteArray(result.Content, 0, 2);
                plcData.CirclePump2State = BitLib.GetBitFromByteArray(result.Content, 0, 3);
                plcData.ValveInState = BitLib.GetBitFromByteArray(result.Content, 0, 4);
                plcData.ValveOutState = BitLib.GetBitFromByteArray(result.Content, 0, 5);
                plcData.SysRunState = BitLib.GetBitFromByteArray(result.Content, 0, 6);
                plcData.SysAlarmState = BitLib.GetBitFromByteArray(result.Content, 0, 7);

                plcData.PressureIn = FloatLib.GetFloatFromByteArray(result.Content, 4);
                plcData.PressureOut = FloatLib.GetFloatFromByteArray(result.Content, 8);
                plcData.TempIn1 = FloatLib.GetFloatFromByteArray(result.Content, 12);
                plcData.TempIn2 = FloatLib.GetFloatFromByteArray(result.Content, 16);
                plcData.TempOut = FloatLib.GetFloatFromByteArray(result.Content, 20);
                plcData.PressureTank1 = FloatLib.GetFloatFromByteArray(result.Content, 24);
                plcData.PressureTank2 = FloatLib.GetFloatFromByteArray(result.Content, 28);
                plcData.LevelTank1 = FloatLib.GetFloatFromByteArray(result.Content, 32);
                plcData.LevelTank2 = FloatLib.GetFloatFromByteArray(result.Content, 36);
                plcData.PressureTankOut = FloatLib.GetFloatFromByteArray(result.Content, 40);

                return OperateResult.CreateSuccessResult<PlcData>(plcData);
            }
            else
            {
                return OperateResult.CreateFailResult<PlcData>(result.Message);
            }
        }

        /// <summary>
        /// 进水泵1控制
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool InPump1Control(bool value)
        {
            string startAddress = "DB1.DBX100.0";
            string stopAddress = "DB1.DBX100.1";
            string controlAdd = value ? startAddress : stopAddress;
            bool result;
            result= s7NetLib.WriteVariable(controlAdd, true).IsSuccess;
            Thread.Sleep(100);
            result&= s7NetLib.WriteVariable(controlAdd, false).IsSuccess;
            return result;
        }
        /// <summary>
        /// 进水泵1控制
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool InPump2Control(bool value)
        {
            string startAddress = "DB1.DBX100.2";
            string stopAddress = "DB1.DBX100.3";
            string controlAdd = value ? startAddress : stopAddress;
            bool result;
            result = s7NetLib.WriteVariable(controlAdd, true).IsSuccess;
            Thread.Sleep(100);
            result &= s7NetLib.WriteVariable(controlAdd, false).IsSuccess;
            return result;
        }
        /// <summary>
        /// 循环泵1控制
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CirclePump1Control(bool value)
        {
            string startAddress = "DB1.DBX100.4";
            string stopAddress = "DB1.DBX100.5";
            string controlAdd = value ? startAddress : stopAddress;
            bool result;
            result = s7NetLib.WriteVariable(controlAdd, true).IsSuccess;
            Thread.Sleep(100);
            result &= s7NetLib.WriteVariable(controlAdd, false).IsSuccess;
            return result;
        }
        /// <summary>
        /// 循环泵2控制
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CirclePump2Control(bool value)
        {
            string startAddress = "DB1.DBX100.6";
            string stopAddress = "DB1.DBX100.7";
            string controlAdd = value ? startAddress : stopAddress;
            bool result;
            result = s7NetLib.WriteVariable(controlAdd, true).IsSuccess;
            Thread.Sleep(100);
            result &= s7NetLib.WriteVariable(controlAdd, false).IsSuccess;
            return result;
        }
        /// <summary>
        /// 系统复位
        /// </summary>
        /// <returns></returns>
        public bool SysReset()
        {
            bool result = default;
            result= s7NetLib.WriteVariable("DB1.DBX101.4", true).IsSuccess;
            Thread.Sleep(80);
            result&= s7NetLib.WriteVariable("DB1.DBX101.4", false).IsSuccess;
            return result;

        }
        /// <summary>
        /// 进水阀控制
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ValveInControl(bool value)
        {
            string startAddress = "DB1.DBX101.0";
            string stopAddress = "DB1.DBX101.1";
            string controlAdd = value ? startAddress : stopAddress;
            bool result;
            result = s7NetLib.WriteVariable(controlAdd, true).IsSuccess;
            Thread.Sleep(100);
            result &= s7NetLib.WriteVariable(controlAdd, false).IsSuccess;
            return result;
        }
        /// <summary>
        /// 出水阀控制
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ValveOutControl(bool value)
        {
            string startAddress = "DB1.DBX101.2";
            string stopAddress = "DB1.DBX101.3";
            string controlAdd = value ? startAddress : stopAddress;
            bool result;
            result = s7NetLib.WriteVariable(controlAdd, true).IsSuccess;
            Thread.Sleep(100);
            result &= s7NetLib.WriteVariable(controlAdd, false).IsSuccess;
            return result;
        }


    }
}
