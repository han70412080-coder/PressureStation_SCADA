using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbd.PressurizationStationPro;

namespace 加压站SCADA
{
    public class SysAdminService
    {
        public List<SysAdmin> QuarySysAdmins()
        {
            string sql = "select LoginId,LoginName,LoginPwd,RoleName from SysAdmin";
            SQLiteDataReader dataReader = SQLiteHelper.ExecuteReader(sql);
            List<SysAdmin> userList = new List<SysAdmin>();
            while (dataReader.Read())
            {
                userList.Add(new SysAdmin()
                {
                    LoginId = Convert.ToInt32(dataReader["LoginId"]),
                    LoginName = dataReader["LoginName"].ToString(),
                    LoginPwd = dataReader["LoginPwd"].ToString(),
                    RoleName = (RoleName) Enum.Parse(typeof(RoleName), dataReader["RoleName"].ToString()),
                });
            }
            dataReader.Close();
            return userList;
        }
        /// <summary>
        /// 登录查询传入返回同一个sysAdmin对象，为空未查到，
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin sysAdmin)
        {
            string sql = "select LoginId,RoleName from SysAdmin where LoginName=@LoginName and LoginPwd=@LoginPwd";
            //SQLiteParameter是参数对象[]是参数对象的集合，参数对象大于两个用[]，里面用new SQLiteParameter("@占位参数",实际参数)
            SQLiteParameter[] sQLiteParameter = new SQLiteParameter[]
            {
                new SQLiteParameter("@LoginName",sysAdmin.LoginName),
                new SQLiteParameter("@LoginPwd",sysAdmin.LoginPwd),
            };
            SQLiteDataReader dataReader = SQLiteHelper.ExecuteReader(sql,sQLiteParameter);
            if (dataReader.Read())
            {
                sysAdmin.LoginId = Convert.ToInt32(dataReader["LoginId"]);
                sysAdmin.RoleName = (RoleName)Enum.Parse(typeof(RoleName), dataReader["RoleName"].ToString());
            }
            else
            {
                sysAdmin = null;
            }
            dataReader.Close();
            return sysAdmin;

        }
    }
}
