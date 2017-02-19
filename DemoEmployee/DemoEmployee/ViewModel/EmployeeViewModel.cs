using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEmployee.Model;

//namespace DemoEmployee.ViewModel
namespace DemoEmployee
{
    public class EmployeeViewModel
    {
        private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees { get { return employees; } }

        public EmployeeViewModel()
        {
            // generate some dummy data for testing purposes
            employees.Add(new Employee { ID = "1001", Firstname = "Jokke", Lastname = "Kuntola", JobTitle = "Account Executive", Image = "Assets/employee01.png" });
            employees.Add(new Employee { ID = "1002", Firstname = "Mathias", Lastname = "Schmidt", JobTitle = "Actuary", Image = "Assets/employee02.png" });
            employees.Add(new Employee { ID = "1003", Firstname = "Janne", Lastname = "Valkonen", JobTitle = "VP Sales", Image = "Assets/employee03.png" });
            employees.Add(new Employee { ID = "1004", Firstname = "Kris", Lastname = "Kettu", JobTitle = "Associate Professor", Image = "Assets/employee04.png" });
            employees.Add(new Employee { ID = "1005", Firstname = "Tiia", Lastname = "Nikula-Ahola", JobTitle = "Administrative Officer", Image = "Assets/employee05.png" });
            employees.Add(new Employee { ID = "1006", Firstname = "Maria", Lastname = "Johnson", JobTitle = "Sales Associate", Image = "Assets/employee06.png" });
            employees.Add(new Employee { ID = "1007", Firstname = "Jean", Lastname = "Sibeluis", JobTitle = "Design Engineer", Image = "Assets/employee07.png" });
            employees.Add(new Employee { ID = "1008", Firstname = "Asta", Lastname = "Wahlsten", JobTitle = "Geologist", Image = "Assets/employee08.png" });
            employees.Add(new Employee { ID = "1009", Firstname = "Anna", Lastname = "Martinez", JobTitle = "Assistant Media Planner", Image = "Assets/employee09.png" });
            employees.Add(new Employee { ID = "1010", Firstname = "Tanja", Lastname = "Peltamo", JobTitle = "Senior Financial Analyst", Image = "Assets/employee10.png" });
        }
    }
}
