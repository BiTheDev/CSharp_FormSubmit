using System;
using System.ComponentModel.DataAnnotations;
namespace FormSubmit.Models
{
    public class Form{

        [Required]
        [MinLength(2)]
        public string First_name{get; set;}

        [Required]
        [MinLength(2)]
        public string Last_name{get; set;}

        [Required]
        public int Age{get; set;}

        [Required]
        public string Email{get; set;}


        [Required]
        [DataType(DataType.Password)]
        public int Password{get; set;}
    }
}