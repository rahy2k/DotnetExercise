using Module.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Module.Models

{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public  string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Username")]
        [MinLength(3,ErrorMessage ="Please Enter Username more than 3 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage ="Please Enter Correct Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter  ConfirmPassword")]
        [Compare("Password",ErrorMessage ="Confirm Password doesn't match")]
        public  string ConfirmPassword { get; set; }
        [RegularExpression("^[6789]\\d{9}$",ErrorMessage = "Please Enter Mobile Number")]
        public string  Contact { get; set; }
        [ValidateRadioButton(ErrorMessage = "Please Enter Gender")]
        public bool Gender { get; set; }
        [ValidateCheckbox(ErrorMessage = "Please Accept Terms")]
        public bool Terms { get; set; }
    }
}
