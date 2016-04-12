using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Models
{
    
    public class EmployeeMasters
    {
        public EmployeeMasters()
        {

        }
      public EmployeeMasters(int EmpID, string EmpName, string Designation, string Email, string Phone, string Address)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.Designation = Designation;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
        }

        [Key]
        public int EmpID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string EmpName { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

    }
}
