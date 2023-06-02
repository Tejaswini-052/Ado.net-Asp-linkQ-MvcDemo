using DatabaseFrameWorkDemo.Data;
using DatabaseFrameWorkDemo.Models;

namespace DatabaseFrameWorkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //update
            /* using (var context = new CompanyDbContext())
             {
                 var existingEntity = context.Departments.Find(3);
                 existingEntity.DeptName = "Project";
                 existingEntity.Location = "Bangalore";
                 context.SaveChanges();
             }*/

            //Add
            //using (var context = new CompanyDbContext())
            //{
            //    Employee emp = new Employee
            //    {
            //        EmpName = "Rahul",
            //        Designation = "Managing"
            //    };
            //    context.Employees.Add(emp);
            //    context.SaveChanges();
            //}

            //delete
            //using (var context = new CompanyDbContext())
            // {
            //     var existingEntity = context.Employees.Find(1);
            //     context.Employees.Remove(existingEntity);
            //     context.SaveChanges();
            // }

           using (var context = new CompanyDbContext())
            {
                var allEntities = context.Departments.ToList();

                foreach (var item in allEntities)
                {
                    Console.WriteLine(item.Id+" "+item.DeptName+" "+ item.Location);
                }
            }




        }
    }
}