using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Table("EmployeeTrigger")]
public partial class EmployeeTrigger
{
    [Key]
    public int PersonelId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Ad { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Soyad { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalOrderAmount { get; set; }
}
