using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_TEST.Models;
using CRUD_TEST.Presenters;
using CRUD_TEST.Repositories;
using CRUD_TEST.Views;
using System.Configuration;

namespace CRUD_TEST
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["CRUD_TEST.Properties.Settings.SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            //IPetRepository repository = new PetRepository(sqlConnectionString);
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
