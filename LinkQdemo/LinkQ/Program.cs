using System.Security.Cryptography.X509Certificates;

namespace LinkQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* string[] names = { "Tejaswini", "Srujana", "Rumman", "Swathi" ,"Shalini"};
             IEnumerable<string> FirstLetter =
                 from name in names
                 where name.StartsWith("S")
                 select name;
             foreach(string name in FirstLetter)
             {
                 Console.WriteLine(name);
             }*/


            int[] num = { 10, 20, 30, 40, 50 };
            int aggregate = num.Aggregate((a, b) => a + b);
            Console.WriteLine(aggregate);

            int elementcount = num.Count();
            Console.WriteLine(elementcount);

            int elementmin = num.Min();
            Console.WriteLine(elementmin);
            int elementmax = num.Max();
            Console.WriteLine(elementmax);

            int elementsum = num.Sum();
            Console.WriteLine(elementsum);



            var employees = from emp in Employee.EmployeeDetails()
                             orderby emp.empid descending
                             select emp;
             foreach(var element in employees)
             {
                 Console.WriteLine(element.empid +" "+element.Name);
             }

            /*var employees1 = from emp in Employee.EmployeeDetails()
                             orderby emp.empid
                             select emp;
             foreach(var element in employees1)
             {
                 Console.WriteLine(element.empid + " " + element.Name);
             }

             var employees2 = Employee.EmployeeDetails().OrderBy(e => e.Name);

             var employees3 = Employee.EmployeeDetails().OrderBy(e => e.Name).ThenBy(e => e.gender);

             var employees4 = Employee.EmployeeDetails().OrderByDescending(e => e.Name).ThenBy(e => e.gender);

             //Elementary

             var employees5 = Employee.EmployeeDetails().ElementAt(2);
             Console.WriteLine(employees5.empid + " " + employees5.Name);

             var employees6 = Employee.EmployeeDetails().ElementAtOrDefault(10);
            Console.WriteLine(employees6.empid + " " + employees6.Name);

             var employees7 = Employee.EmployeeDetails().First();
             Console.WriteLine(employees7.empid + " " + employees7.Name);

            var employees8 = Employee.EmployeeDetails().FirstOrDefault(e => e.Name == "Ravi");
             Console.WriteLine(employees7.empid + " " + employees8.Name);

             var employees9 = Employee.EmployeeDetails().Last();
             Console.WriteLine(employees9.empid + " " + employees9.Name);

            var employees10 = Employee.EmployeeDetails().LastOrDefault();
           Console.WriteLine(employees10.empid + " " + employees10.Name);

             string[] value = {"Tejaswini","Srujana"};
             var item = value.DefaultIfEmpty();
             foreach(var val in item)
             {
                 Console.WriteLine(val);
             }

              var employees11 = Employee.EmployeeDetails().Single();
             Console.WriteLine(employees11.empid + " " + employees11.Name);

            var employees12 = Employee.EmployeeDetails().SingleOrDefault();
            Console.WriteLine(employees12.empid + " " + employees12.Name);*/

              

        }
    }
}