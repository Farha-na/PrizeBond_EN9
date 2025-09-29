using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOL.Entities;

[Table("bond_history")]
public partial class BondHistory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Column("hb_id")]
    public int ObId { get; set; }

    [Column("hb_bond_series")]
    [StringLength(2)]
    public string ObBondSeries { get; set; }

    [Column("hb_bond_no")]
    public int ObBondNo { get; set; }
}