using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class Department
    {
        [key]
        public int Id { get; set; }

        public string DeptName { get; set; }
        public string location { get; set; }
    }
}
