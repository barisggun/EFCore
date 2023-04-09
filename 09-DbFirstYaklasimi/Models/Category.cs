using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Index("CategoryName", Name = "CategoryName")]
public partial class Category
{
    [Key]
    [Column("CategoryID")]
    [DisplayName("Kategori Id")]
    public int CategoryId { get; set; }

    [StringLength(15)]
    [DisplayName("Kategori Adı")]
    [Required(ErrorMessage ="Zorunlu alan")]
    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    [DisplayName("Açıklama")]
    public string? Description { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    [DisplayName("Resim Url")]
    public string? ImageUrl { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
