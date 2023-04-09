using System;
using System.Collections.Generic;

namespace MVC_Odev01_Products.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
