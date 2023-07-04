using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CopyDataToJson;

public partial class SourcesDbContext : DbContext
{
    public SourcesDbContext()
    {
    }

    public SourcesDbContext(DbContextOptions<SourcesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<MapCountry> MapCountries { get; set; }

    public virtual DbSet<MapLanguage> MapLanguages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DBAUXIPRESS1; Database=SourcesDB; User Id=sa; Password=Stanley56CM; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("French_CI_AS");

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("Contact", tb =>
                {
                    tb.HasComment("Les contacts (journalistes)");
                    tb.HasTrigger("AddContact");
                    tb.HasTrigger("UniqueMediascoreIDToContact");
                    tb.HasTrigger("UpdateContact");
                });

            entity.HasIndex(e => new { e.ContactId, e.MapSalutationId }, "IX_Contact");

            entity.HasIndex(e => new { e.LastName, e.FirstName }, "IX_ContactLastnameFirstName");

            entity.HasIndex(e => e.MapSalutationId, "IX_ContactSalutationID");

            entity.HasIndex(e => new { e.Active, e.ContactId }, "IX_Contact_Active");

            entity.HasIndex(e => e.ContactId, "IX_Contact_FullName");

            entity.HasIndex(e => e.FullName, "IX_Contact_FullName2");

            entity.HasIndex(e => new { e.LastName, e.FirstName }, "IX_LastNameFirstName");

            entity.HasIndex(e => e.MediaScoreId, "SQLTRINX_Contact_MediaScoreID");

            entity.HasIndex(e => e.MediaScoreId, "SQLTRINX_Contact_MediaScoreID_Includes");

            entity.HasIndex(e => new { e.MediaScoreId, e.UpdateMs }, "SQLTRINX_Contact_MediaScoreID_UpdateMS");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(127);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(127);
            entity.Property(e => e.MapSalutationId).HasColumnName("MapSalutationID");
            entity.Property(e => e.MediaScoreId).HasColumnName("MediaScoreID");
            entity.Property(e => e.ModBy).HasMaxLength(255);
            entity.Property(e => e.ModDate).HasColumnType("datetime");
            entity.Property(e => e.PresentInJp).HasColumnName("PresentInJP");
            entity.Property(e => e.UpdateMs).HasColumnName("UpdateMS");
        });

        modelBuilder.Entity<MapCountry>(entity =>
        {
            entity.HasKey(e => e.MapCountryId).HasName("PK_MapMapCountry");

            entity.ToTable("MapCountry", tb => tb.HasComment("Liste des pays (ISO 3166-1)"));

            entity.Property(e => e.MapCountryId).HasColumnName("MapCountryID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CodeIso2)
                .HasMaxLength(2)
                .HasColumnName("CodeISO2");
            entity.Property(e => e.CodeIso3)
                .HasMaxLength(3)
                .HasColumnName("CodeISO3");
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
            entity.Property(e => e.JumboPilotId)
                .HasMaxLength(5)
                .HasColumnName("JumboPilotID");
            entity.Property(e => e.MediascoreId).HasColumnName("MediascoreID");
        });

        modelBuilder.Entity<MapLanguage>(entity =>
        {
            entity.ToTable("MapLanguage", tb => tb.HasComment("Liste des langues (ISO 639-1)"));

            entity.HasIndex(e => e.CodeIso, "IX_MapLanguage").IsUnique();

            entity.Property(e => e.MapLanguageId).HasColumnName("MapLanguageID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CodeIso)
                .HasMaxLength(2)
                .HasColumnName("CodeISO");
            entity.Property(e => e.CodeIso2)
                .HasMaxLength(3)
                .HasColumnName("CodeISO2");
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
            entity.Property(e => e.JumboPilotId)
                .HasMaxLength(5)
                .HasColumnName("JumboPilotID");
            entity.Property(e => e.MediascoreId).HasColumnName("MediascoreID");
            entity.Property(e => e.NewbaseName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
