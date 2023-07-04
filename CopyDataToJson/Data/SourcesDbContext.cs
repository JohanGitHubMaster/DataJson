using System;
using System.Collections.Generic;
using CopyDataToJson.Models;
using Microsoft.EntityFrameworkCore;

namespace CopyDataToJson.Data;

public partial class SourcesDbContext : DbContext
{
    public SourcesDbContext()
    {
    }

    public SourcesDbContext(DbContextOptions<SourcesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Medium> Media { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DBAUXIPRESS1; Database=SourcesDB; User Id=sa; Password=Stanley56CM; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("French_CI_AS");

        modelBuilder.Entity<Medium>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasComment("Les sources (publications)");
                    tb.HasTrigger("InsertLinkid");
                    tb.HasTrigger("UniqueJumboPilotID");
                    tb.HasTrigger("UniqueMediascoreID");
                    tb.HasTrigger("UpdateMedia");
                });

            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.ActiveJp).HasDefaultValueSql("((1))");
            entity.Property(e => e.ActiveMs).HasDefaultValueSql("((1))");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DigitalRights).HasDefaultValueSql("((1))");
            entity.Property(e => e.GoPress).HasDefaultValueSql("((0))");
            entity.Property(e => e.PublicationMaster).HasDefaultValueSql("((0))");
            entity.Property(e => e.RealPdf).HasDefaultValueSql("((1))");
            entity.Property(e => e.Texthandling).HasDefaultValueSql("((2))");
            entity.Property(e => e.Up2News).HasDefaultValueSql("((0))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
