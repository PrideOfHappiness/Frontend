using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blazor1.Models;

namespace blazor1.Pages{
    public partial class EmployeePage{
        public IEnumerable<Employee> Employees { get;set;}
        
        protected override Task OnInitializedAsync(){
            LoadEmployee();
            return base.OnInitializedAsync();
        }
        
        private void LoadEmployee(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Erick",
                LastName="Kurniawan",
                Email="erick@actual-training.com",
                DateOfBirth = new DateTime(1999,10,5),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=1,DepartmentName="Sistem Informasi"},
                PhotoPath = "pictures/erick.jpg"
            };

            Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Budi",
                LastName="Sutedjo",
                Email="budi@actual-training.com",
                DateOfBirth = new DateTime(1999,10,5),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="HR"},
                PhotoPath = "pictures/budi.jpg"
            };

            Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Argo",
                LastName="Wibowo",
                Email="argo@actual-training.com",
                DateOfBirth = new DateTime(2000,5,5),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=1,DepartmentName="Sistem Informasi"},
                PhotoPath = "pictures/argo.jpg"
            };

            Employee e4 = new Employee{
                EmployeeId=3,
                FirstName="Cloud",
                LastName="Strife",
                Email="cloud@actual-training.com",
                DateOfBirth = new DateTime(2000,6,5),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=1,DepartmentName="Sistem Informasi"},
                PhotoPath = "pictures/cloud.jpg"
            };

            Employees = new List<Employee>{e1, e2, e3, e4};
        }
    }
}