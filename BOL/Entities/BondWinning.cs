using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOL.Entities;

[Table("bond_winning")]
public partial class BondWinning
{
    [Key]
    [Column("wb_id")]
    public int WbId { get; set; }

    [Column("wb_draw_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string WbDrawName { get; set; }

    [Column("wb_bond_no")]
    public int? WbBondNo { get; set; }

    [Column("wb_win_place")]
    public int? WbWinPlace { get; set; }

    [Column("wb_entry_sl")]
    public int? WbEntrySl { get; set; }
}