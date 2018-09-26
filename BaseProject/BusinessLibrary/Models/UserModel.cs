using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Models
{
    public class UserModel
    {
        public int idUser;
        public string userName;
        public string password;
        public int idEmployee;

        public int IdUser { get => idUser; set => idUser = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
    }
}
