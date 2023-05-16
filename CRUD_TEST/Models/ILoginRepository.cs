using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TEST.Models
{
    public interface ILoginRepository
    {
        void login(string username, string password);
        void logout();
        IEnumerable<LoginModel> GetUserByUsername(string value);
    }
}
