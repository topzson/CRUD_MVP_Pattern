using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_TEST.Models;
using CRUD_TEST.Views;
using CRUD_TEST.Repositories;
using System.Security.Cryptography;

namespace CRUD_TEST.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPetView += ShowPetsView;
            this.mainView.ShowViewLogin += ShowLoginView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetView view = PetView.GetInstance((MainView)mainView);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
        }
        
        private void ShowLoginView(object sender, EventArgs e)
        {
            ILoginView view = LoginView.GetInstance((MainView)mainView);
            ILoginRepository repository = new LoginRepository(sqlConnectionString);
            new LoginPresenter(view, repository);
        }
    }
}
