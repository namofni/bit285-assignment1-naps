//From Wing S Cho BIT 285 Winter 2019
using System;
using System.ComponentModel.DataAnnotations;

namespace bit285assignment1naps.Models
{
    public class User
    {
        [Required(ErrorMessage ="Please enter your first name")]
        public string firstName { get; set; }

        [Required(ErrorMessage ="Please enter your last name")]
        public string lastName { get; set; }

        [Required(ErrorMessage ="Please enter your email address.")]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid email address")]
        public string email { get; set; }

        public string password { get; set; }

        //[Required(ErrorMessage ="Please select your program")]
        public string program { get; set; }

        //[Required(ErrorMessage = "Please enter your birth year")]
        public string birthYear { get; set; }

        //[Required(ErrorMessage = "Please select your favorite color")]
        public string favColor { get; set; }
    }
}
