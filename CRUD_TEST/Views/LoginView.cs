using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TEST.Views
{
    public partial class LoginView : Form ,ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public event EventHandler LoginEvent;
        public event EventHandler LogoutEvent;
        public event EventHandler SignupEvent;
        public event EventHandler ForgetPassEvent;


        private static LoginView instance;
        public static ILoginView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LoginView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;

            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();

            }
            return instance;
        }
    }
}
