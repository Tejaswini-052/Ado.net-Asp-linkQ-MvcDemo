using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFrameWorkDemo.Models;

[Table("Department")]
public partial class Department
{
    [Key]
    public int Id { get; set; }

    public string DeptName { get; set; } = null!;

    [Column("location")]
    public string Location { get; set; } = null!;
}
