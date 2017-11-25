using System.ComponentModel.DataAnnotations;

namespace AgioTest.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [RegularExpression(@"^(\d{6}|\d{8})[-\s]?\d{4}$", ErrorMessage = "Email is not valid")]
        public string PersonalNumber { get; set; }

        public string EmployeeNumber { get; set; }
    }
}
