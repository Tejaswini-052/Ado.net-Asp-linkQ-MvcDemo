using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQ
{
    public class Employee
    {
        public string empid {get;set;}
        public string Name { get; set; }
        public string Department { get; set; }
        public string gender { get; set; }

        public static List<Employee> EmployeeDetails()
        {
            List<Employee> listofemployees = new List<Employee>
            {
                new Employee{empid="a1",Name="Tejaswini",Department="cse",gender="Female"},
                new Employee{empid="a2",Name="Rumman",Department="ise",gender="Female"},
                new Employee{empid="a3",Name="Swathi",Department="eee",gender="Female"},
                new Employee{empid="a4",Name="Darshan",Department="me",gender="Male"},
                new Employee{empid="a5",Name="Anoop",Department="cv",gender="Male"}
            };
            return listofemployees;
        }
    }
}
