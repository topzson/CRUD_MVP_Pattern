using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TEST.Views
{
    public interface ILoginView
    {
        //event
        event EventHandler LoginEvent;
        event EventHandler LogoutEvent;
        event EventHandler SignupEvent;
        event EventHandler ForgetPassEvent;



        void Show();
    }
}
