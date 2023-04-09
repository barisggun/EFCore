using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

public partial class MyUser
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Fullname { get; set; } = null!;
}
