using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Table("Yazarlar")]
public partial class Yazarlar
{
    [Key]
    [Column("YazarID")]
    public int YazarId { get; set; }

    [Column("Yazarlar")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Yazarlar1 { get; set; }

    [InverseProperty("YazarNavigation")]
    public virtual ICollection<Kitaplar> Kitaplars { get; } = new List<Kitaplar>();
}
