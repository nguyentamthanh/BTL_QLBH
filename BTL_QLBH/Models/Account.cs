using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_QLBH.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage ="username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="PassWord is required")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}