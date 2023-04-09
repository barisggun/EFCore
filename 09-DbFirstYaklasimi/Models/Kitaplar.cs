using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Table("Kitaplar")]
public partial class Kitaplar
{
    [Key]
    public int KitapId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KitapAdi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Yazar { get; set; }

    [Column("KategoriID")]
    public int? KategoriId { get; set; }

    [Column("YazarID")]
    public int? YazarId { get; set; }

    [ForeignKey("YazarId")]
    [InverseProperty("Kitaplars")]
    public virtual Yazarlar? YazarNavigation { get; set; }
}
