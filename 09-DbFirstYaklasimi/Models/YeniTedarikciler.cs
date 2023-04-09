using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Keyless]
[Table("YeniTedarikciler")]
public partial class YeniTedarikciler
{
    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [Column("ÜLKE")]
    [StringLength(15)]
    public string? Ülke { get; set; }
}
