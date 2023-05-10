using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TEST.Models

{
    public class PetModel
    {
        //fields
        private int id;
        private string name;
        private string type;
        private string color;

        [DisplayName("Pet ID")]
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet name is required.")]
        [StringLength(50,MinimumLength = 3,ErrorMessage = "Pet name must be between 3 and 50 charaters")]
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type must be between 3 and 50 charaters")]
        public string Type 
        { 
            get => type; 
            set => type = value; 
        }
        [DisplayName("Pet color")]
        [Required(ErrorMessage = "Pet color is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet color must be between 3 and 50 charaters")]
        public string Color 
        { 
            get => color; 
            set => color = value; 
        }
    }
}

