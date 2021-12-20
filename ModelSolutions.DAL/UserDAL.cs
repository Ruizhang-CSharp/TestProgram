using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelTable;


namespace ModelSolutions.DAL
{
    public class UserDAL
    {
        
        public int Login(string uName,string uPwd)
        {
            using (TableModel tab = new TableModel())
            {
                var userTable = tab.UserTable.Where(t => t.Name == uName).FirstOrDefault();
                if (userTable == null)
                {
                    return 0; // 用户名不存在
                }
                if (userTable.Passward == uPwd)
                {
                    return 1; // 用户密码正确
                }
                return 2; // 密码错误
            }
        }
    }
}
