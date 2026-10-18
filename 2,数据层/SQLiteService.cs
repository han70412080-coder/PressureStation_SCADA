using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbd.PressurizationStationPro;

namespace 加压站SCADA
{
    public class SQLiteService
    {
        /// <summary>
        /// 设置连接字符串
        /// </summary>
        /// <param name="sql"></param>
        public void SetConnectStr(string sql)
        {
            SQLiteHelper.ConnString = sql;
        }
    }
}
