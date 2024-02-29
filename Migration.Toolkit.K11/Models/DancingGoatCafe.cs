﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Migration.Toolkit.K11.Models;

[Table("DancingGoat_Cafe")]
public partial class DancingGoatCafe
{
    [Key]
    [Column("CafeID")]
    public int CafeId { get; set; }

    [StringLength(50)]
    public string CafeStreet { get; set; } = null!;

    [StringLength(50)]
    public string CafeCity { get; set; } = null!;

    [StringLength(100)]
    public string CafeCountry { get; set; } = null!;

    [StringLength(15)]
    public string CafeZipCode { get; set; } = null!;

    [StringLength(30)]
    public string CafePhone { get; set; } = null!;

    [StringLength(100)]
    public string? CafeEmail { get; set; }

    public Guid? CafePhoto { get; set; }

    [Column("CafeIsAlsoARoastery")]
    public bool? CafeIsAlsoAroastery { get; set; }

    public bool? CafeIsPartner { get; set; }

    [StringLength(50)]
    public string? CafeName { get; set; }
}
