using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CopyDataToJson;

public partial class AuxipressContext : DbContext
{
    public AuxipressContext()
    {
    }

    public AuxipressContext(DbContextOptions<AuxipressContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VwebOrders1> VwebOrders1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DBAUXIPRESS1; Database=auxipress; User Id=sa; Password=Stanley56CM; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AI");

        modelBuilder.Entity<VwebOrders1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWebOrders1");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Customer).HasMaxLength(255);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.KProject).HasColumnName("K_PROJECT");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
