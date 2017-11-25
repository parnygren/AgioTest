using AgioTest.Models;
using System.Collections.Generic;

namespace AgioTest.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
