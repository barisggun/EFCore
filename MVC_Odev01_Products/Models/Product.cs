using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Odev01_Products.Models;

public partial class Product
{
    public int ProductId { get; set; }

    [DisplayName("Ürün Adı")]
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Boş geçilemez alan")]
    public string ProductName { get; set; } = null!;

   
    public int? SupplierId { get; set; }

    
    public int? CategoryId { get; set; }

    public string? QuantityPerUnit { get; set; }

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public short? UnitsOnOrder { get; set; }

    public short? ReorderLevel { get; set; }

    [DisplayName("İndirimli Mi?")]
    public bool Discontinued { get; set; }

    [DisplayName("Kategori Adı")]
    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
    [DisplayName("Tedarikçi Adı")]
    public virtual Supplier? Supplier { get; set; }
}
