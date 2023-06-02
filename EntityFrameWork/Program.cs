using Azure.Core;
using EntityFrameWork.data;
using EntityFrameWork.Models;

namespace EntityFrameWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            using CompanydbContext context = new CompanydbContext();
            /* Employee emp = new Employee
             {
                 EmpName = "Rumman",
                 designation = "Java developer",
             };

             context.Add(emp);
             context.SaveChanges();*/

            /*Department dept = new Department
            {
                DeptName = "Testing",
                location = "Udupi",
            };

            context.Add(dept);
            context.SaveChanges();*/

            //update
            /*var employee = context.Employee.Where(p=>p.Id==1).First();
            if(employee is Employee)
            {
                employee.EmpName = "Ravi";
            }
            context.SaveChanges();*/

            //delete
            /*var dept = context.Department.Where(p => p.Id == 1).First();
            if(dept is Department)
            {
                context.Remove(dept);
            }
            context.SaveChanges();*/

            //print

            /*var PrintEmp = from emp1 in context.Employee
                           where emp1.EmpName.StartsWith("S")
                           select emp1;

            foreach(Employee val in PrintEmp)
            {
                Console.WriteLine(val.Id + " " +" "+val.EmpName+" "+val.designation);
            }*/


            var PrintDept = from dep in context.Department
                           where dep.location=="Udupi"
                           select dep;
            foreach (Department val in PrintDept)
            {
                Console.WriteLine(val.Id + " " + " " + val.DeptName + " " + val.location);
            }


        }
    }
}