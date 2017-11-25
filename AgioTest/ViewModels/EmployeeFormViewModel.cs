using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgioTest.ViewModels
{
    public class EmployeeFormViewModel
    {
        [Required]
        public string FirstName { get; set; }        

        [Required]
        public string LastName { get; set; }

        public string PersonalNumber { get; set; }
        public string EmployeeNumber { get; set; }
    }
}
