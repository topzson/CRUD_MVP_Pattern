using CRUD_TEST.Models;
using CRUD_TEST.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TEST.Presenters
{
    public class PetPresenter
    {
            private IPetView view;
            private IPetRepository repository;
            private BindingSource petBindingSource;
            private IEnumerable<PetModel> petList;
            
            public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;

            this.view.SetPetListBindingSource(petBindingSource);

            LoadAllPetList();
            this.view.Show();

        }

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petBindingSource.DataSource = petList;
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petBindingSource.DataSource = petList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
    
        }

        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetId);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Color = view.PetColor;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Pet edited successfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Pet added sucessfuly";
                    CleanviewFields();
                }
                view.IsSuccessful = true;
                LoadAllPetList();

            }catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColor = "";
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }

        private void LoadSelectPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColor = pet.Color;
            view.IsEdit = true;
        
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;

        }
    }
}
