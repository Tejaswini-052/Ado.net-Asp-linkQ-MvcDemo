using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class Employee
    {
        [key]
        public int Id { get; set; }

        public string EmpName { get; set; }
        public string designation { get; set; }
    }
}
