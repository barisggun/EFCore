using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Keyless]
[Table("Test Tablosu")]
public partial class TestTablosu
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Surname { get; set; }
}
