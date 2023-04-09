using System;
using System.Collections.Generic;

namespace MVC_Odev01_Products.Models;

public partial class KitapKategorileri
{
    public int Id { get; set; }

    public int? KitapId { get; set; }

    public int? KategoriId { get; set; }

    public virtual Kategoriler IdNavigation { get; set; } = null!;

    public virtual Kitaplar? Kategori { get; set; }
}
