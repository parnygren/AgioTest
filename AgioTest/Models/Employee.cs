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

        public string PersonalNumber { get; set; }
        public string EmployeeNumber { get; set; }
    }
}
