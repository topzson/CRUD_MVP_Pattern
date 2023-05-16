using CRUD_TEST.Models;
using CRUD_TEST.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TEST.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private ILoginRepository repository;
        private IEnumerable<LoginModel> LoginList;

        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.Show();
  

        }


    }
}
