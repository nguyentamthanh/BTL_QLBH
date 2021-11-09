using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_QLBH.Models
{
    public class Product
    {
        [Key]
        public string ProductId  { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
        public DateTime DateTime { get; set; }

    }
}