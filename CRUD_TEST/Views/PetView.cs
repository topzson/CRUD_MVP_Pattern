using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TEST.Views
{
    public partial class PetView : Form , IPetView
    {
        private string message;
        private bool isEdit;
        private bool isSuccessful;
      
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            Tap_table.TabPages.Remove(tap_curd2);
            X_btn.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvent()
        {
            search_btn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            search_txt.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //ADD
            Add_btn.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                Tap_table.TabPages.Remove(tap_curd1);
                Tap_table.TabPages.Add(tap_curd2);
                tap_curd2.Text = "Add new pet";
            };
            //EDIT
            edit_btn.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty);
                Tap_table.TabPages.Remove(tap_curd1);
                Tap_table.TabPages.Add(tap_curd2);
                tap_curd2.Text = "Edit new pet";
            };
            
            //SAVE
            save_btn.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    Tap_table.TabPages.Remove(tap_curd2);
                    Tap_table.TabPages.Add(tap_curd1);

                }
                MessageBox.Show(Message);

            };
            //DELETE
            delete_btn.Click += delegate { 
                
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes) {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                
                
                }
                
            };
            //cancal
            cancel_btn.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                Tap_table.TabPages.Remove(tap_curd2);
                Tap_table.TabPages.Add(tap_curd1);
            };
        }

        public string PetId { get => pet_id_tb.Text; set => pet_id_tb.Text = value; }
        public string PetName { get => pet_name_tb.Text; set => pet_name_tb.Text = value; }
        public string PetType { get => pet_tpe_tb.Text; set => pet_tpe_tb.Text = value; }
        public string PetColor { get => pet_color_tb.Text; set => pet_color_tb.Text = value; }
        public string SearchValue { get => search_btn.Text; set => search_btn.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

 
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }
        //sigleton
        private static PetView instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock= DockStyle.Fill;
            
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
