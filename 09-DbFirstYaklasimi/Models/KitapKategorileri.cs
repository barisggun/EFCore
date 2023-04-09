using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Keyless]
[Table("KitapKategorileri")]
public partial class KitapKategorileri
{
    public int Id { get; set; }

    [Column("KitapID")]
    public int? KitapId { get; set; }

    [Column("KategoriID")]
    public int? KategoriId { get; set; }

    [ForeignKey("Id")]
    public virtual Kategoriler IdNavigation { get; set; } = null!;

    [ForeignKey("KategoriId")]
    public virtual Kitaplar? Kategori { get; set; }
}
