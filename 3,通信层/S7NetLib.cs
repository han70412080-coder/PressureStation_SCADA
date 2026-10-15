using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.DataConvertLib;
using xbd.s7netplus;
using DataType = xbd.s7netplus.DataType;

namespace 加压站SCADA
{
    public class S7NetLib
    {
        private Plc seimens;

        public CpuType cpuType { get; set; }
        public string IPAddress { get; set; }
        public short Rack { get; set; }
        public short Slot { get; set; }
        public S7NetLib()
        {

        }
        /// <summary>
        /// 有参构造
        /// </summary>
        /// <param name="cpuType"></param>
        /// <param name="ipAddress"></param>
        /// <param name="Rack"></param>
        /// <param name="Slot"></param>
        public S7NetLib(CpuType cpuType, string ipAddress, short Rack, short Slot)
        {
            this.cpuType = cpuType;
            this.IPAddress = ipAddress;
            this.Rack = Rack;
            this.Slot = Slot;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public OperateResult Connect()
        {
            if (seimens != null && seimens.IsConnected)
            {
                seimens.Close();
            }
            try
            {
                seimens = new Plc(cpuType, IPAddress, Rack, Slot);
                seimens.Open();
                return OperateResult.CreateSuccessResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "链接失败");
                return OperateResult.CreateFailResult(ex.Message);
            }
        }

        public OperateResult DisConnect()
        {
            if (seimens != null && seimens.IsConnected)
            {
                seimens.Close();
                return OperateResult.CreateSuccessResult();
            }
            else
            {
                return OperateResult.CreateFailResult();
            }

        }
        //byte[],singleVariable,Readclass

        public OperateResult<object> ReadSingleVariable(string Variable)
        {
            if (seimens != null && seimens.IsConnected)
            {
                try
                {
                    lock (obj)
                    {

                        return OperateResult.CreateSuccessResult(seimens.Read(Variable));
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<object>(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult<object>("连接有误");
            }
        }

        private readonly Object obj = new object();
        /// <summary>
        /// 读取数据返回数组
        /// </summary>
        /// <param name="dataType">types of memory area that can be read,EX:DataType.DataBlock表示读取DB区域，同理还有I，Q，M存储区</param>
        /// <param name="db">DB1，哪个DB块</param>
        /// <param name="start">开始位</param>
        /// <param name="count">从开始读取多少位</param>
        /// <returns></returns>
        public OperateResult<byte[]> ReadByByteArray(DataType dataType, int db, int start, int count)
        {
            if (seimens != null && seimens.IsConnected)
            {
                try
                {
                    lock (obj)
                    {
                        return OperateResult.CreateSuccessResult<byte[]>(seimens.ReadBytes(dataType, db, start, count));
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<byte[]>(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult<byte[]>("连接有误");
            }
        }
        public OperateResult<T> ReadByClass<T>(int db, int start) where T : class
        {
            if (seimens != null && seimens.IsConnected)
            {
                try
                {
                    lock (obj)
                    {
                        return OperateResult.CreateSuccessResult<T>(seimens.ReadClass<T>(db, start));
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<T>(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult<T>("连接有误");
            }
        }
        public OperateResult WriteVariable(string WriAdd, object value)
        {
            if (seimens != null && seimens.IsConnected)
            {
                try
                {
                    lock (obj)
                    {
                        seimens.Write(WriAdd, value);
                        return OperateResult.CreateSuccessResult();
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult("连接有误");
            }
        }

    }


}
