using CRUD_TEST.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TEST.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
       

        public LoginRepository(string connenctionString) { 
            this.connenctionString = connenctionString;
        }

        public IEnumerable<LoginModel> GetUserByUsername(string value)
        {
            throw new NotImplementedException();
        }

        public void login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void logout()
        {
            throw new NotImplementedException();
        }
    }
}
