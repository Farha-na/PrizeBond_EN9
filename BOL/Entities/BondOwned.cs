using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOL.Entities;

[Table("bond_owned")]
public partial class BondOwned
{
    [Key]
    [Column("ob_id")]
    [StringLength(10)]
    public string ObId { get; set; }

    [Column("ob_bond_series")]
    [StringLength(2)]
    public string ObBondSeries { get; set; }

    [Column("ob_bond_no")]
    [StringLength(10)]
    public string ObBondNo { get; set; }
}