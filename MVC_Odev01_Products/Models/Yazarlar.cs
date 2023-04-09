using System;
using System.Collections.Generic;

namespace MVC_Odev01_Products.Models;

public partial class Yazarlar
{
    public int YazarId { get; set; }

    public string? Yazarlar1 { get; set; }

    public virtual ICollection<Kitaplar> Kitaplars { get; } = new List<Kitaplar>();
}
