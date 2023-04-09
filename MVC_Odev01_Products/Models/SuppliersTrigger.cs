using System;
using System.Collections.Generic;

namespace MVC_Odev01_Products.Models;

public partial class SuppliersTrigger
{
    public int SupplierId { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactName { get; set; }

    public string? ContactTitle { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? IslemTipi { get; set; }

    public DateTime? IslemTarihi { get; set; }
}
