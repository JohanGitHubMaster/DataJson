using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CopyDataToJson;

public partial class ProfileDbContext : DbContext
{
    public ProfileDbContext()
    {
    }

    public ProfileDbContext(DbContextOptions<ProfileDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Keyword> Keywords { get; set; }

    public virtual DbSet<KeywordCondition> KeywordConditions { get; set; }

    public virtual DbSet<KeywordDescription> KeywordDescriptions { get; set; }

    public virtual DbSet<KeywordGeneral> KeywordGenerals { get; set; }

    public virtual DbSet<KeywordGroup> KeywordGroups { get; set; }

    public virtual DbSet<KeywordHit> KeywordHits { get; set; }

    public virtual DbSet<KeywordLine> KeywordLines { get; set; }

    public virtual DbSet<Lock> Locks { get; set; }

    public virtual DbSet<MapConditionType> MapConditionTypes { get; set; }

    public virtual DbSet<MapCoverpageType> MapCoverpageTypes { get; set; }

    public virtual DbSet<MapCutType> MapCutTypes { get; set; }

    public virtual DbSet<MapFlow> MapFlows { get; set; }

    public virtual DbSet<MapHighlightType> MapHighlightTypes { get; set; }

    public virtual DbSet<MapHighlightTypeWeb> MapHighlightTypeWebs { get; set; }

    public virtual DbSet<MapKeywordType> MapKeywordTypes { get; set; }

    public virtual DbSet<MapLocation> MapLocations { get; set; }

    public virtual DbSet<MapSendingLink> MapSendingLinks { get; set; }

    public virtual DbSet<OrderRubric> OrderRubrics { get; set; }

    public virtual DbSet<OrderSetting> OrderSettings { get; set; }

    public virtual DbSet<OrderWebRubric> OrderWebRubrics { get; set; }

    public virtual DbSet<ProfilOther> ProfilOthers { get; set; }

    public virtual DbSet<VallOrdersSubscriptionType> VallOrdersSubscriptionTypes { get; set; }

    public virtual DbSet<VkeyWordNmh> VkeyWordNmhs { get; set; }

    public virtual DbSet<Vkeyword> Vkeywords { get; set; }

    public virtual DbSet<VkeywordWebDescription> VkeywordWebDescriptions { get; set; }

    public virtual DbSet<VkeywordsAll> VkeywordsAlls { get; set; }

    public virtual DbSet<VmapLanguage> VmapLanguages { get; set; }

    public virtual DbSet<VminHitsWeb> VminHitsWebs { get; set; }

    public virtual DbSet<VorderWebWithPriority> VorderWebWithPriorities { get; set; }

    public virtual DbSet<VordersKeyword> VordersKeywords { get; set; }

    public virtual DbSet<VordersRubric> VordersRubrics { get; set; }

    public virtual DbSet<VordersType> VordersTypes { get; set; }

    public virtual DbSet<VordersWebSetting> VordersWebSettings { get; set; }

    public virtual DbSet<Vreport> Vreports { get; set; }

    public virtual DbSet<VwebActive> VwebActives { get; set; }

    public virtual DbSet<VwrittenPressOrder> VwrittenPressOrders { get; set; }

    public virtual DbSet<Workpackage> Workpackages { get; set; }

    public virtual DbSet<WorkpackageWebclip> WorkpackageWebclips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DBAUXIPRESS1; Database=ProfileDB; User Id=sa; Password=Stanley56CM; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Keyword>(entity =>
        {
            entity.ToTable("Keyword");

            entity.HasIndex(e => new { e.Orderid, e.KtTypeid }, "IX_Keyword_Orderid_KT_Typeid");

            entity.HasIndex(e => new { e.Orderid, e.KtTypeid }, "IX_Keyword_Orderid_KT_Typeid2");

            entity.HasIndex(e => new { e.Orderid, e.KtTypeid, e.KeywordId }, "IX_Keyword_Orderid_KT_Typeid_KeywordID");

            entity.HasIndex(e => new { e.Orderid, e.KtTypeid, e.LaLanguageid }, "IX_Keyword_Orderid_KT_Typeid_LA_Languageid");

            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.KeywordString)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KT_Typeid");
            entity.Property(e => e.LaLanguageid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LA_Languageid");
            entity.Property(e => e.ModBy)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ModDate).HasColumnType("datetime");

            entity.HasOne(d => d.KtType).WithMany(p => p.Keywords)
                .HasForeignKey(d => d.KtTypeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Keyword_MapKeywordType");
        });

        modelBuilder.Entity<KeywordCondition>(entity =>
        {
            entity.ToTable("KeywordCondition");

            entity.HasIndex(e => e.KeywordLineId, "IX_KeywordCondition_KeywordLineID");

            entity.HasIndex(e => new { e.KeywordLineId, e.KeywordConditionId }, "IX_KeywordCondition_KeywordLineID_KeywordConditionID");

            entity.Property(e => e.KeywordConditionId).HasColumnName("KeywordConditionID");
            entity.Property(e => e.KcConditionTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KC_ConditionTypeid");
            entity.Property(e => e.Keyword)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KeywordConditionName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");

            entity.HasOne(d => d.KcConditionType).WithMany(p => p.KeywordConditions)
                .HasForeignKey(d => d.KcConditionTypeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeywordCondition_MapConditionType");

            entity.HasOne(d => d.KeywordLine).WithMany(p => p.KeywordConditions)
                .HasForeignKey(d => d.KeywordLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeywordCondition_KeywordLine");
        });

        modelBuilder.Entity<KeywordDescription>(entity =>
        {
            entity.ToTable("KeywordDescription");

            entity.HasIndex(e => e.KeywordName, "IX_KeywordDescription_Name");

            entity.HasIndex(e => e.KeywordLineId, "IX_KeywordDescription_Orderid");

            entity.Property(e => e.KeywordDescriptionId).HasColumnName("KeywordDescriptionID");
            entity.Property(e => e.KeywordDescFr)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescFR");
            entity.Property(e => e.KeywordDescHtmlfr)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescHTMLFR");
            entity.Property(e => e.KeywordDescHtmlfrweb).HasColumnName("KeywordDescHTMLFRWeb");
            entity.Property(e => e.KeywordDescHtmlnl)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescHTMLNL");
            entity.Property(e => e.KeywordDescHtmlnlweb).HasColumnName("KeywordDescHTMLNLWeb");
            entity.Property(e => e.KeywordDescNl)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescNL");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KeywordWebDescriptionHtml).HasColumnName("KeywordWebDescriptionHTML");

            entity.HasOne(d => d.KeywordLine).WithMany(p => p.KeywordDescriptions)
                .HasForeignKey(d => d.KeywordLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeywordDescription_KeywordLine");
        });

        modelBuilder.Entity<KeywordGeneral>(entity =>
        {
            entity.ToTable("KeywordGeneral");

            entity.HasIndex(e => e.Active, "IDX_KG_ACTIVE");

            entity.HasIndex(e => e.Orderid, "IX_KeywordGeneral_Orderid").IsUnique();

            entity.HasIndex(e => e.WebActive, "IX_KeywordGeneral_WebActive");

            entity.Property(e => e.KeywordGeneralId).HasColumnName("KeywordGeneralID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.FromDateActiveWp).HasColumnName("FromDateActiveWP");
            entity.Property(e => e.FromDateWp)
                .HasColumnType("datetime")
                .HasColumnName("FromDateWP");
            entity.Property(e => e.ProfileAdditionFr)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ProfileAdditionFR");
            entity.Property(e => e.ProfileAdditionFrweb).HasColumnName("ProfileAdditionFRWeb");
            entity.Property(e => e.ProfileAdditionHtmlfr)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ProfileAdditionHTMLFR");
            entity.Property(e => e.ProfileAdditionHtmlfrweb).HasColumnName("ProfileAdditionHTMLFRWeb");
            entity.Property(e => e.ProfileAdditionHtmlnl)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ProfileAdditionHTMLNL");
            entity.Property(e => e.ProfileAdditionHtmlnlweb).HasColumnName("ProfileAdditionHTMLNLWeb");
            entity.Property(e => e.ProfileAdditionNl)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("ProfileAdditionNL");
            entity.Property(e => e.ProfileAdditionNlweb).HasColumnName("ProfileAdditionNLWeb");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.ToDateActiveWp).HasColumnName("ToDateActiveWP");
            entity.Property(e => e.ToDateWp)
                .HasColumnType("datetime")
                .HasColumnName("ToDateWP");
            entity.Property(e => e.WorkPackageId).HasColumnName("WorkPackageID");
        });

        modelBuilder.Entity<KeywordGroup>(entity =>
        {
            entity.ToTable("KeywordGroup");

            entity.HasIndex(e => e.KtTypeid, "IX_KeywordGroup_KT_Typeid");

            entity.HasIndex(e => e.Orderid, "IX_KeywordGroup_Orderid");

            entity.HasIndex(e => new { e.Orderid, e.KtTypeid }, "IX_KeywordGroup_Orderid_KT_Typeid");

            entity.HasIndex(e => new { e.Orderid, e.KtTypeid }, "IX_KeywordGroup_Orderid_KT_Typeid2");

            entity.HasIndex(e => new { e.Orderid, e.KtTypeid, e.KeywordGroupId }, "IX_KeywordGroup_Orderid_KT_Typeid_KeywordGroupID");

            entity.Property(e => e.KeywordGroupId).HasColumnName("KeywordGroupID");
            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KT_Typeid");
            entity.Property(e => e.LaLanguageid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LA_Languageid");

            entity.HasOne(d => d.KtType).WithMany(p => p.KeywordGroups)
                .HasForeignKey(d => d.KtTypeid)
                .HasConstraintName("FK_KeywordGroup_MapKeywordType");
        });

        modelBuilder.Entity<KeywordHit>(entity =>
        {
            entity.ToTable("KeywordHit");

            entity.HasIndex(e => e.KeywordLineId, "IX_KeywordHit_KeywordLineID");

            entity.Property(e => e.KeywordHitId).HasColumnName("KeywordHitID");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName).HasMaxLength(255);
            entity.Property(e => e.MinHits).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.KeywordLine).WithMany(p => p.KeywordHits)
                .HasForeignKey(d => d.KeywordLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeywordHit_KeywordLine");
        });

        modelBuilder.Entity<KeywordLine>(entity =>
        {
            entity.ToTable("KeywordLine");

            entity.HasIndex(e => e.KeywordGroupId, "IX_KL_KeywordName_KeywordInclude_KeywordAllKeywords");

            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.KeywordGroupId).HasColumnName("KeywordGroupID");
            entity.Property(e => e.KeywordInclude)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.KeywordName).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ToDate).HasColumnType("datetime");

            entity.HasOne(d => d.KeywordGroup).WithMany(p => p.KeywordLines)
                .HasForeignKey(d => d.KeywordGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeywordLine_KeywordGroup");
        });

        modelBuilder.Entity<Lock>(entity =>
        {
            entity.HasKey(e => e.LockId).HasName("PK__Lock__E7C1E21256F62A85");

            entity.ToTable("Lock");

            entity.HasIndex(e => e.Orderid, "IX_Lock_Orderid");

            entity.HasIndex(e => new { e.Orderid, e.LockedDate }, "IX_Lock_Orderid_LockedDate");

            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.IsLockedRtvpixel).HasColumnName("IsLockedRTVPixel");
            entity.Property(e => e.IsLockedRtvvocRec).HasColumnName("IsLockedRTVVocRec");
            entity.Property(e => e.LockedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<MapConditionType>(entity =>
        {
            entity.HasKey(e => e.KcConditionTypeid);

            entity.ToTable("MapConditionType");

            entity.HasIndex(e => e.MapConditionTypeId, "IX_MapConditionType_MapConditionTypeID").IsUnique();

            entity.Property(e => e.KcConditionTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KC_ConditionTypeid");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DescDutch)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescEnglish)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescFrench)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescGerman)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Description).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MapConditionTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MapConditionTypeID");
        });

        modelBuilder.Entity<MapCoverpageType>(entity =>
        {
            entity.ToTable("MapCoverpageType");

            entity.Property(e => e.MapCoverpageTypeId).HasColumnName("MapCoverpageTypeID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescDutch)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescEnglish)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescFrench)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescGerman)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<MapCutType>(entity =>
        {
            entity.ToTable("MapCutType");

            entity.Property(e => e.MapCutTypeId).HasColumnName("MapCutTypeID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
        });

        modelBuilder.Entity<MapFlow>(entity =>
        {
            entity.ToTable("MapFlow");

            entity.Property(e => e.MapFlowId).HasColumnName("MapFlowID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(1000);
        });

        modelBuilder.Entity<MapHighlightType>(entity =>
        {
            entity.ToTable("MapHighlightType");

            entity.Property(e => e.MapHighlightTypeId).HasColumnName("MapHighlightTypeID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescDutch)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescEnglish)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescFrench)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescGerman)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<MapHighlightTypeWeb>(entity =>
        {
            entity.ToTable("MapHighlightTypeWeb");

            entity.Property(e => e.MapHighlightTypeWebId).HasColumnName("MapHighlightTypeWebID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
        });

        modelBuilder.Entity<MapKeywordType>(entity =>
        {
            entity.HasKey(e => e.KtTypeid);

            entity.ToTable("MapKeywordType");

            entity.HasIndex(e => e.MapKeywordTypeId, "IX_MapKeywordType_MapKeywordTypeID").IsUnique();

            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KT_Typeid");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DescDutch)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescEnglish)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescFrench)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DescGerman)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Description).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MapKeywordTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MapKeywordTypeID");
        });

        modelBuilder.Entity<MapLocation>(entity =>
        {
            entity.ToTable("MapLocation");

            entity.Property(e => e.MapLocationId).HasColumnName("MapLocationID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
        });

        modelBuilder.Entity<MapSendingLink>(entity =>
        {
            entity.ToTable("MapSendingLink");

            entity.Property(e => e.MapSendingLinkId).HasColumnName("MapSendingLinkID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<OrderRubric>(entity =>
        {
            entity.ToTable("OrderRubric");

            entity.HasIndex(e => new { e.Orderid, e.Rubric }, "IX_OrderRubric_OrderRubricUniq").IsUnique();

            entity.Property(e => e.OrderRubricId).HasColumnName("OrderRubricID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Rubric)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<OrderSetting>(entity =>
        {
            entity.HasKey(e => e.OrderSettingsId).HasName("PK__Template__F87ADD071A394237");

            entity.ToTable(tb => tb.HasTrigger("CopyToWebClipActive"));

            entity.HasIndex(e => e.Orderid, "IX_OrderSettings").IsUnique();

            entity.Property(e => e.OrderSettingsId).HasColumnName("OrderSettingsID");
            entity.Property(e => e.Ave).HasColumnName("AVE");
            entity.Property(e => e.Aveweb).HasColumnName("AVEWeb");
            entity.Property(e => e.MapCoverpageTypeId).HasColumnName("MapCoverpageTypeID");
            entity.Property(e => e.MapCutTypeId)
                .HasDefaultValueSql("((3))")
                .HasColumnName("MapCutTypeID");
            entity.Property(e => e.MapFlowId).HasColumnName("MapFlowID");
            entity.Property(e => e.MapHighlightTypeId).HasColumnName("MapHighlightTypeID");
            entity.Property(e => e.MapHighlightTypeWebId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("MapHighlightTypeWebID");
            entity.Property(e => e.MapLocationId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("MapLocationID");
            entity.Property(e => e.MapSendingLinkId)
                .HasDefaultValueSql("((2))")
                .HasColumnName("MapSendingLinkID");
            entity.Property(e => e.Qa).HasColumnName("QA");
            entity.Property(e => e.Qaweb).HasColumnName("QAWeb");

            entity.HasOne(d => d.MapCoverpageType).WithMany(p => p.OrderSettings)
                .HasForeignKey(d => d.MapCoverpageTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSettings_MapCoverpageType");

            entity.HasOne(d => d.MapCutType).WithMany(p => p.OrderSettings)
                .HasForeignKey(d => d.MapCutTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSettings_MapCutType");

            entity.HasOne(d => d.MapFlow).WithMany(p => p.OrderSettings)
                .HasForeignKey(d => d.MapFlowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSettings_MapFlow");

            entity.HasOne(d => d.MapHighlightType).WithMany(p => p.OrderSettings)
                .HasForeignKey(d => d.MapHighlightTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSettings_MapHighlightType");

            entity.HasOne(d => d.MapLocation).WithMany(p => p.OrderSettings)
                .HasForeignKey(d => d.MapLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSettings_MapLocation");

            entity.HasOne(d => d.MapSendingLink).WithMany(p => p.OrderSettings)
                .HasForeignKey(d => d.MapSendingLinkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderSettings_MapSendingLink");
        });

        modelBuilder.Entity<OrderWebRubric>(entity =>
        {
            entity.ToTable("OrderWebRubric");

            entity.Property(e => e.OrderWebRubricId).HasColumnName("OrderWebRubricID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Rubric).HasMaxLength(255);
        });

        modelBuilder.Entity<ProfilOther>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProfilOther");

            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.OrderSettingsId).HasColumnName("OrderSettingsID");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
        });

        modelBuilder.Entity<VallOrdersSubscriptionType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VAllOrdersSubscriptionType");

            entity.Property(e => e.Customer)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.KProject).HasColumnName("K_PROJECT");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
        });

        modelBuilder.Entity<VkeyWordNmh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VKeyWordNMH");

            entity.Property(e => e.KeywordDescFr)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescFR");
            entity.Property(e => e.KeywordDescHtmlfr)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescHTMLFR");
            entity.Property(e => e.KeywordDescHtmlfrweb).HasColumnName("KeywordDescHTMLFRWeb");
            entity.Property(e => e.KeywordDescHtmlnl)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescHTMLNL");
            entity.Property(e => e.KeywordDescHtmlnlweb).HasColumnName("KeywordDescHTMLNLWeb");
            entity.Property(e => e.KeywordDescNl)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordDescNL");
            entity.Property(e => e.KeywordDescriptionId).HasColumnName("KeywordDescriptionID");
            entity.Property(e => e.KeywordGroupId).HasColumnName("KeywordGroupID");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KeywordNameDsc)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("KeywordNameDSC");
            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KT_Typeid");
        });

        modelBuilder.Entity<Vkeyword>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VKeywords");

            entity.Property(e => e.CodeIso2)
                .HasMaxLength(3)
                .UseCollation("French_CI_AS")
                .HasColumnName("CodeISO2");
            entity.Property(e => e.ConditionName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.KcConditionTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KC_ConditionTypeid");
            entity.Property(e => e.Keyword)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KeywordConditionId).HasColumnName("KeywordConditionID");
            entity.Property(e => e.KeywordConditionName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KeywordGroupId).HasColumnName("KeywordGroupID");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KT_Typeid");
            entity.Property(e => e.LaLanguageid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LA_Languageid");
            entity.Property(e => e.LanguageName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VkeywordWebDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VKeywordWebDescription");

            entity.Property(e => e.ConditionTypeName)
                .HasMaxLength(256)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.IsVisible)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.KcConditionTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KC_ConditionTypeid");
            entity.Property(e => e.Keyword)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("keyword");
            entity.Property(e => e.KeywordDescHtmlfrweb).HasColumnName("KeywordDescHTMLFRWeb");
            entity.Property(e => e.KeywordDescHtmlnlweb).HasColumnName("KeywordDescHTMLNLWeb");
            entity.Property(e => e.KeywordDescriptionId).HasColumnName("KeywordDescriptionID");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.NbOfWordsCondition)
                .HasMaxLength(18)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VkeywordsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VKeywordsAll");

            entity.Property(e => e.CodeIso2)
                .HasMaxLength(3)
                .UseCollation("French_CI_AS")
                .HasColumnName("CodeISO2");
            entity.Property(e => e.ConditionName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.KcConditionTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KC_ConditionTypeid");
            entity.Property(e => e.Keyword)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KeywordConditionId).HasColumnName("KeywordConditionID");
            entity.Property(e => e.KeywordConditionName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KeywordGroupId).HasColumnName("KeywordGroupID");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KT_Typeid");
            entity.Property(e => e.LaLanguageid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LA_Languageid");
            entity.Property(e => e.LanguageName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmapLanguage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VMapLanguage");

            entity.Property(e => e.CodeIso)
                .HasMaxLength(2)
                .UseCollation("French_CI_AS")
                .HasColumnName("CodeISO");
            entity.Property(e => e.CodeIso2)
                .HasMaxLength(3)
                .UseCollation("French_CI_AS")
                .HasColumnName("CodeISO2");
            entity.Property(e => e.DescDutch)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DescEnglish)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DescFrench)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DescGerman)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Description).UseCollation("French_CI_AS");
            entity.Property(e => e.JumboPilotId)
                .HasMaxLength(5)
                .UseCollation("French_CI_AS")
                .HasColumnName("JumboPilotID");
            entity.Property(e => e.MapLanguageId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MapLanguageID");
            entity.Property(e => e.MediascoreId).HasColumnName("MediascoreID");
            entity.Property(e => e.NewbaseName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<VminHitsWeb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VMinHitsWeb");

            entity.Property(e => e.KeywordGroupId).HasColumnName("KeywordGroupID");
            entity.Property(e => e.KeywordHitId).HasColumnName("KeywordHitID");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName).HasMaxLength(255);
        });

        modelBuilder.Entity<VorderWebWithPriority>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VOrderWebWithPriority");

            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.Customer)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.IsNotOk).HasColumnName("IsNotOK");
            entity.Property(e => e.IsOk).HasColumnName("IsOK");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.OrderName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.ProfileAdditionHtmlfrweb).HasColumnName("ProfileAdditionHTMLFRWeb");
            entity.Property(e => e.ProfileAdditionHtmlnlweb).HasColumnName("ProfileAdditionHTMLNLWeb");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
        });

        modelBuilder.Entity<VordersKeyword>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VOrdersKeywords");

            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");
            entity.Property(e => e.KeywordString)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("KT_Typeid");
            entity.Property(e => e.LaLanguageid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LA_Languageid");
            entity.Property(e => e.LanguageName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<VordersRubric>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VOrdersRubrics");

            entity.Property(e => e.Customer).HasMaxLength(255);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName).HasMaxLength(255);
            entity.Property(e => e.Rubric)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");
        });

        modelBuilder.Entity<VordersType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VOrdersType");

            entity.Property(e => e.ProfileName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.WebActive).HasColumnName("Web_Active");
            entity.Property(e => e.WebActive1).HasColumnName("WebActive");
            entity.Property(e => e.WpActive).HasColumnName("WP_Active");
        });

        modelBuilder.Entity<VordersWebSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VOrdersWebSettings");

            entity.Property(e => e.CutType).HasMaxLength(255);
            entity.Property(e => e.Flow).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.SendingLink).HasMaxLength(255);
        });

        modelBuilder.Entity<Vreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VReport");

            entity.Property(e => e.KeywordGroupId).HasColumnName("KeywordGroupID");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName).UseCollation("SQL_Latin1_General_CP1_CS_AS");
            entity.Property(e => e.KtTypeid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("KT_Typeid");
            entity.Property(e => e.LaLanguageid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("LA_Languageid");
        });

        modelBuilder.Entity<VwebActive>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWebActive");

            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");
            entity.Property(e => e.KeywordString)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.LaLanguageid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("LA_Languageid");
        });

        modelBuilder.Entity<VwrittenPressOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWrittenPressOrders");

            entity.Property(e => e.OrderName).HasMaxLength(255);
            entity.Property(e => e.ProfileAdditionFr)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("ProfileAdditionFR");
            entity.Property(e => e.ProfileAdditionNl)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasColumnName("ProfileAdditionNL");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CS_AS");
        });

        modelBuilder.Entity<Workpackage>(entity =>
        {
            entity.ToTable("Workpackage");

            entity.Property(e => e.WorkpackageId)
                .ValueGeneratedNever()
                .HasColumnName("WorkpackageID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.WorkpackageName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<WorkpackageWebclip>(entity =>
        {
            entity.HasKey(e => e.WorkpackageId);

            entity.ToTable("WorkpackageWebclip");

            entity.Property(e => e.WorkpackageId)
                .ValueGeneratedNever()
                .HasColumnName("WorkpackageID");
            entity.Property(e => e.WorkpackageName)
                .HasMaxLength(255)
                .HasDefaultValueSql("((1))")
                .UseCollation("Latin1_General_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
