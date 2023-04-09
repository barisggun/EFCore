using System;
using System.Collections.Generic;

namespace MVC_Odev01_Products.Models;

public partial class EmployeeTrigger
{
    public int PersonelId { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public decimal? TotalOrderAmount { get; set; }
}
