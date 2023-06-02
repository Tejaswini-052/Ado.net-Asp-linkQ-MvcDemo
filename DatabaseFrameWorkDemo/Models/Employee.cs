using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFrameWorkDemo.Models;

[Table("Employee")]
public partial class Employee
{
    [Key]
    public int Id { get; set; }

    public string EmpName { get; set; } = null!;

    [Column("designation")]
    public string Designation { get; set; } = null!;
}
