using ModelSolutions.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSolutionS.BLL
{
    public class UserBLL
    {
        UserDAL useDAL = new UserDAL();
        public int LoginSystem(string uName,string uPwd)
        {
            return useDAL.Login(uName, uPwd);
        }
    }
}
