using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BTL_QLBH.Models
{
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="FirstName is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is require")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Username is require")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is require")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password is require")]
        public string ConfirmPassword { get; set; }

    }
}