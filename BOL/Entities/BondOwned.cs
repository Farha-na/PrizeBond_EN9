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
    public int ObId { get; set; }

    //failed to turn off identity (1,1)
    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    //[Column("ob_id_2")]
    //public int ObId_2 { get; set; }

    [Column("ob_bond_series")]
    [StringLength(2)]
    public string ObBondSeries { get; set; }

    [Column("ob_bond_no")]
    public int ObBondNo { get; set; }
}