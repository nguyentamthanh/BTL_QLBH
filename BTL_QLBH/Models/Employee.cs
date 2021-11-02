using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLBH.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
