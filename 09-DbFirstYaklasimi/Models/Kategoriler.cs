using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Table("Kategoriler")]
public partial class Kategoriler
{
    [Key]
    [Column("KategoriID")]
    public int KategoriId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KategoriAdı { get; set; }
}
