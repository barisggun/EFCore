using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Table("Testo")]
public partial class Testo
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Text { get; set; }

    [StringLength(50)]
    public string? Desc { get; set; }

    [StringLength(50)]
    public string? Address { get; set; }
}
