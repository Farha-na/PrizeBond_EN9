using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BOL.Entities;

namespace DAL.DataContext;

public partial class db_prizebond_DBContext : DbContext
{
    public db_prizebond_DBContext()
    {
    }

    public db_prizebond_DBContext(DbContextOptions<db_prizebond_DBContext> options) : base(options)
    {
    }

    public DbSet<BondOwned> BondOwned_instances { get; set; }

    public DbSet<BondWinning> BondWinnings { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=.;Database=db_prizebond;User Id=sa;Password=hihowareyou;TrustServerCertificate=True");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<BondOwned>(entity =>
    //    {
    //        entity.Property(e => e.ObId).IsFixedLength();
    //        entity.Property(e => e.ObBondNo).IsFixedLength();
    //    });

    //    modelBuilder.Entity<BondWinning>(entity =>
    //    {
    //        entity.Property(e => e.WbId).ValueGeneratedNever();
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //private partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}