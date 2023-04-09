using System;
using System.Collections.Generic;

namespace MVC_Odev01_Products.Models;

public partial class Kitaplar
{
    public int KitapId { get; set; }

    public string? KitapAdi { get; set; }

    public string? Yazar { get; set; }

    public int? KategoriId { get; set; }

    public int? YazarId { get; set; }

    public virtual Yazarlar? YazarNavigation { get; set; }
}
