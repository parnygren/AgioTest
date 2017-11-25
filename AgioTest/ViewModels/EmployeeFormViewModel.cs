using System.ComponentModel.DataAnnotations;

namespace AgioTest.ViewModels
{
    public class EmployeeFormViewModel
    {
        [Required]
        public string FirstName { get; set; }        

        [Required]
        public string LastName { get; set; }

        [PersonalNumber]
        public string PersonalNumber { get; set; }

        public string EmployeeNumber { get; set; }
    }
}
