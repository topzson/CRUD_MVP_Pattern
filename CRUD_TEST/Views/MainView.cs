using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TEST.Views
{
    public partial class MainView : Form ,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnPet.Click += delegate { ShowPetView?.Invoke(this, EventArgs.Empty); };

        }

        public event EventHandler ShowPetView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowView;
    }
}
