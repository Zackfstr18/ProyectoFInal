using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDat userDat = new UserDat();
        public bool LoginUser(string user, string pass, string Cargo)
        {
            return userDat.Login(user, pass, Cargo);
        }

        
    }
}