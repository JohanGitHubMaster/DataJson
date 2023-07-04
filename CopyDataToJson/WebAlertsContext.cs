using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CopyDataToJson;

public partial class WebAlertsContext : DbContext
{
    public WebAlertsContext()
    {
    }

    public WebAlertsContext(DbContextOptions<WebAlertsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<AlertEmail> AlertEmails { get; set; }

    public virtual DbSet<AlertRetro> AlertRetros { get; set; }

    public virtual DbSet<ArticleKeyword> ArticleKeywords { get; set; }

    public virtual DbSet<ArticleSelected> ArticleSelecteds { get; set; }

    public virtual DbSet<ArticleWordFound> ArticleWordFounds { get; set; }

    public virtual DbSet<MainSource> MainSources { get; set; }

    public virtual DbSet<MapCut> MapCuts { get; set; }

    public virtual DbSet<MapOriginalFlow> MapOriginalFlows { get; set; }

    public virtual DbSet<MapProvider> MapProviders { get; set; }

    public virtual DbSet<MapStatus> MapStatuses { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<ProfileHistory> ProfileHistories { get; set; }

    public virtual DbSet<ProfileLock> ProfileLocks { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<SourceImage> SourceImages { get; set; }

    public virtual DbSet<SourceOp> SourceOps { get; set; }

    public virtual DbSet<SourceOpimage> SourceOpimages { get; set; }

    public virtual DbSet<SourcePr> SourcePrs { get; set; }

    public virtual DbSet<SourcePrimage> SourcePrimages { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAction> UserActions { get; set; }

    public virtual DbSet<VaddToHerme> VaddToHermes { get; set; }

    public virtual DbSet<VarticleToValidate> VarticleToValidates { get; set; }

    public virtual DbSet<VarticleToValidate2> VarticleToValidate2s { get; set; }

    public virtual DbSet<VarticlesOrderToTreat> VarticlesOrderToTreats { get; set; }

    public virtual DbSet<VarticlesToCut> VarticlesToCuts { get; set; }

    public virtual DbSet<Vherme> Vhermes { get; set; }

    public virtual DbSet<VlistOrdersCountArticle> VlistOrdersCountArticles { get; set; }

    public virtual DbSet<VrecupOpoint> VrecupOpoints { get; set; }

    public virtual DbSet<Vtalkwalker> Vtalkwalkers { get; set; }

    public virtual DbSet<VwebAlertKeyWordDescription> VwebAlertKeyWordDescriptions { get; set; }

    public virtual DbSet<VwebGuruWaiting> VwebGuruWaitings { get; set; }

    public virtual DbSet<VwebTalkwalker> VwebTalkwalkers { get; set; }

    public virtual DbSet<WaitingSource> WaitingSources { get; set; }

    public virtual DbSet<WaitingSourceImage> WaitingSourceImages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DBAUXIPRESS1; Database=WebAlerts; User Id=sa; Password=Stanley56CM; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alert>(entity =>
        {
            entity.ToTable("Alert");

            entity.HasIndex(e => new { e.OrderId, e.SourceId }, "DTX_Alert_OrderID_SourcesID");

            entity.HasIndex(e => new { e.OrderId, e.AlertDate }, "IX_Alert_OrderID_AlertDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderId, e.AlertDate, e.Validated }, "IX_Alert_OrderID_AlertDate_Validated").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderId, e.Validated, e.AlertDate }, "IX_Alert_OrderID_Validated_AlertDate").HasFillFactor(90);

            entity.HasIndex(e => e.Validated, "IX_Alert_Validated").HasFillFactor(90);

            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AlertDate).HasColumnType("datetime");
            entity.Property(e => e.BlockUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Issue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.KeyWord).IsUnicode(false);
            entity.Property(e => e.Lang)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.SourceName).HasMaxLength(200);
            entity.Property(e => e.SourceUrl).IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Url).IsUnicode(false);
            entity.Property(e => e.ValidatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ValidationDate).HasColumnType("datetime");
            entity.Property(e => e.WordFound).IsUnicode(false);

            entity.HasOne(d => d.Order).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alert_OrderDetail");

            //entity.HasOne(d => d.Source).WithMany(p => p.Alerts)
            //    .HasForeignKey(d => d.SourceId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_Alert_Alert");
        });

        modelBuilder.Entity<AlertEmail>(entity =>
        {
            entity.ToTable("AlertEmail");

            entity.Property(e => e.AlertEmailId).HasColumnName("AlertEmailID");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Language)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.Alert).WithMany(p => p.AlertEmails)
                .HasForeignKey(d => d.AlertId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertEmail_Alert");
        });

        modelBuilder.Entity<AlertRetro>(entity =>
        {
            entity.ToTable("AlertRetro");

            entity.Property(e => e.AlertRetroId).HasColumnName("AlertRetroID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ArticleKeyword>(entity =>
        {
            entity.ToTable("ArticleKeyword");

            entity.HasIndex(e => e.ArticleSelectedId, "IDX_ArtKey_ArticleSelectedID").HasFillFactor(90);

            entity.HasIndex(e => e.ArticleSelectedId, "IDX_ArticleKeyword_ArticleSelectedID");

            entity.HasIndex(e => e.ArticleSelectedId, "IDX_ArticleKeyword_ArticlesSelectedID");

            entity.Property(e => e.ArticleKeywordId).HasColumnName("ArticleKeywordID");
            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.Extract).HasMaxLength(4000);
            entity.Property(e => e.ExtractKeyword).HasMaxLength(2000);

            entity.HasOne(d => d.ArticleSelected).WithMany(p => p.ArticleKeywords)
                .HasForeignKey(d => d.ArticleSelectedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArticleKeyword_ArticleSelected");
        });

        modelBuilder.Entity<ArticleSelected>(entity =>
        {
            entity.ToTable("ArticleSelected");

            entity.HasIndex(e => e.ToTreat, "IDX_ArticleSelected_ToTreat");

            entity.HasIndex(e => new { e.OrderId, e.ToTreat }, "IDX_ArticleSelected_ToTreat2");

            entity.HasIndex(e => new { e.OrderId, e.ToTreat, e.Validated, e.Cut }, "IX_ArticleSelected_OrderID_ToTreat_Validated_Cut");

            entity.HasIndex(e => e.SourceId, "IX_ArticleSelected_SourceID");

            entity.HasIndex(e => new { e.SourceId, e.OrderId }, "IX_ArticleSelected_SourceID_OrderID");

            entity.HasIndex(e => new { e.SourceId, e.ToTreat, e.Validated, e.OrderId, e.Cut }, "IX_ArticleSelected_SourceID_ToTreat_Validated_OrderID_Cut");

            entity.HasIndex(e => new { e.ToTreat, e.Validated, e.Cut }, "IX_ArticleSelected_ToTreat_Validated_Cut");

            entity.HasIndex(e => new { e.ToTreat, e.Validated, e.OrderId, e.Cut }, "IX_ArticleSelected_ToTreat_Validated_OrderID_Cut");

            entity.HasIndex(e => new { e.ToTreat, e.Validated, e.ValidatedBy, e.ValidationDate }, "IX_ArticleSelected_ToTreat_Validated_ValidatedBy_ValidationDate");

            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.CutBy).HasMaxLength(100);
            entity.Property(e => e.CutDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.RubricId).HasColumnName("RubricID");
            entity.Property(e => e.SelectionDate).HasColumnType("datetime");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.ToTreat)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Uivalidated).HasColumnName("UIValidated");
            entity.Property(e => e.ValidatedBy).HasMaxLength(100);
            entity.Property(e => e.ValidationDate).HasColumnType("datetime");

            //entity.HasOne(d => d.Source).WithMany(p => p.ArticleSelecteds)
            //    .HasForeignKey(d => d.SourceId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_ArticleSelected_Source");
        });

        modelBuilder.Entity<ArticleWordFound>(entity =>
        {
            entity.ToTable("ArticleWordFound");

            entity.HasIndex(e => e.ArticleSelectedId, "NonClusteredIndex-20200702-095600").HasFillFactor(90);

            entity.Property(e => e.ArticleWordFoundId).HasColumnName("ArticleWordFoundID");
            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.KeywordFound).HasMaxLength(500);
            entity.Property(e => e.KeywordSource).HasMaxLength(500);

            entity.HasOne(d => d.ArticleSelected).WithMany(p => p.ArticleWordFounds)
                .HasForeignKey(d => d.ArticleSelectedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArticleWordFound_ArticleSelected");
        });

        modelBuilder.Entity<MainSource>(entity =>
        {
            entity.ToTable("MainSource");

            entity.Property(e => e.MainSourceId)
                .ValueGeneratedNever()
                .HasColumnName("MainSourceID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.SiteName)
                .HasMaxLength(255)
                .HasColumnName("site_name");
            entity.Property(e => e.SiteUrl)
                .HasMaxLength(255)
                .HasColumnName("site_url");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<MapCut>(entity =>
        {
            entity.HasKey(e => e.CutId);

            entity.ToTable("MapCut");

            entity.Property(e => e.CutId)
                .ValueGeneratedNever()
                .HasColumnName("CutID");
            entity.Property(e => e.Description).HasMaxLength(200);
        });

        modelBuilder.Entity<MapOriginalFlow>(entity =>
        {
            entity.ToTable("MapOriginalFlow");

            entity.Property(e => e.MapOriginalFlowId)
                .ValueGeneratedNever()
                .HasColumnName("MapOriginalFlowID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DescDutch).HasMaxLength(255);
            entity.Property(e => e.DescEnglish).HasMaxLength(255);
            entity.Property(e => e.DescFrench).HasMaxLength(255);
            entity.Property(e => e.DescGerman).HasMaxLength(255);
        });

        modelBuilder.Entity<MapProvider>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MapProvider");

            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
        });

        modelBuilder.Entity<MapStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("MapStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("OrderDetail");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.Comment).IsUnicode(false);
        });

        modelBuilder.Entity<ProfileHistory>(entity =>
        {
            entity.ToTable("ProfileHistory");

            entity.HasIndex(e => e.ValidationDate, "IDX_ProfileHistory_ValidationDate");

            entity.Property(e => e.ProfileHistoryId).HasColumnName("ProfileHistoryID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ValidatedBy).HasMaxLength(100);
            entity.Property(e => e.ValidationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProfileLock>(entity =>
        {
            entity.ToTable("ProfileLock");

            entity.Property(e => e.ProfileLockId).HasColumnName("ProfileLockID");
            entity.Property(e => e.LockBy).HasMaxLength(100);
            entity.Property(e => e.LockDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.ToTable("Source");

            entity.HasIndex(e => new { e.ForGuru, e.Status2 }, "DTX_Source_ForGuru_Status2");

            entity.HasIndex(e => new { e.ContactId, e.ToTalkwalker }, "IDX_Source_ContactID_ToTalkwalker");

            entity.HasIndex(e => new { e.ForGuru, e.Status2 }, "IDX_Source_ForGuru_Status2");

            entity.HasIndex(e => e.InsertedDate, "IDX_Source_InsertedDate");

            entity.HasIndex(e => e.MediaId, "IDX_Source_MediaID");

            entity.HasIndex(e => e.ProviderId, "IDX_Source_ProviderID");

            entity.HasIndex(e => new { e.ToTalkwalker, e.SourceId }, "IDX_Source_SourceID_ToTalkwalker");

            entity.HasIndex(e => new { e.Status, e.ForWebAlert }, "IDX_Source_Status_ForWebAlert");

            entity.HasIndex(e => new { e.ToTalkwalker, e.PublicationDate }, "IDX_Source_TW_PublicationDate");

            entity.HasIndex(e => e.FilePath, "IX_Source_FilePath").HasFillFactor(90);

            entity.HasIndex(e => new { e.Status2, e.ForGuru }, "IX_Source_ForGuruStatus2").HasFillFactor(90);

            entity.HasIndex(e => new { e.Status, e.ForWebAlert }, "IX_Source_ForWebAlertStatus").HasFillFactor(90);

            entity.HasIndex(e => e.Issue, "IX_Source_Issue");

            entity.HasIndex(e => e.Url, "Ix_Url").HasFillFactor(90);

            entity.HasIndex(e => new { e.Status, e.ForWebAlert }, "dt_Source_WebAlert_Status");

            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.ArticleId).HasMaxLength(50);
            entity.Property(e => e.Author)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.FromProvider)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fromProvider");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.Issue).HasMaxLength(50);
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.LastModificationDate).HasColumnType("datetime");
            entity.Property(e => e.LockedBy).HasMaxLength(200);
            entity.Property(e => e.MainCaption)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MainImage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MainSourceId).HasColumnName("MainSourceID");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.Prid).HasColumnName("PRID");
            entity.Property(e => e.ProviderId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ProviderID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.SourceUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Summary)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ToTalkwalker)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Url)
                .HasMaxLength(1700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SourceImage>(entity =>
        {
            entity.ToTable("SourceImage");

            entity.HasIndex(e => e.SourceId, "IDX_SourceImage_SourceID");

            entity.Property(e => e.SourceImageId).HasColumnName("SourceImageID");
            entity.Property(e => e.IsValid)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");

            //entity.HasOne(d => d.Source).WithMany(p => p.SourceImages)
            //    .HasForeignKey(d => d.SourceId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_SourceImage_Source");
        });

        modelBuilder.Entity<SourceOp>(entity =>
        {
            entity.ToTable("SourceOP");

            entity.HasIndex(e => e.InsertedDate, "IDX_SourceOP_InsertionDate");

            entity.Property(e => e.SourceOpid).HasColumnName("SourceOPID");
            entity.Property(e => e.ArticleId).HasMaxLength(50);
            entity.Property(e => e.Author)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.Issue).HasMaxLength(50);
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.MainCaption)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MainImage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MainSourceId).HasColumnName("MainSourceID");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.SourceUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Summary)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(1700)
                .IsUnicode(false);

            entity.HasOne(d => d.MainSource).WithMany(p => p.SourceOps)
                .HasForeignKey(d => d.MainSourceId)
                .HasConstraintName("FK_SourceOP_MainSource");
        });

        modelBuilder.Entity<SourceOpimage>(entity =>
        {
            entity.ToTable("SourceOPImage");

            entity.Property(e => e.SourceOpimageId).HasColumnName("SourceOPImageID");
            entity.Property(e => e.IsValid)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SourceOpid).HasColumnName("SourceOPID");

            entity.HasOne(d => d.SourceOp).WithMany(p => p.SourceOpimages)
                .HasForeignKey(d => d.SourceOpid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SourceOPImage_SourceOP");
        });

        modelBuilder.Entity<SourcePr>(entity =>
        {
            entity.ToTable("SourcePR");

            entity.HasIndex(e => e.InsertionDate, "IDX_SourcePR_InsertionDate");

            entity.HasIndex(e => e.Prid, "IX_SourcePR_PRID").IsUnique();

            entity.Property(e => e.SourcePrid).HasColumnName("SourcePRID");
            entity.Property(e => e.Author)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.InsertionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.LastModificationDate).HasColumnType("datetime");
            entity.Property(e => e.MainImage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.MediaPrid).HasColumnName("MediaPRID");
            entity.Property(e => e.Prid).HasColumnName("PRID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.Status2).HasDefaultValueSql("((0))");
            entity.Property(e => e.Title).HasMaxLength(2000);
            entity.Property(e => e.Url)
                .HasMaxLength(1700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SourcePrimage>(entity =>
        {
            entity.ToTable("SourcePRImage");

            entity.Property(e => e.SourcePrimageId).HasColumnName("SourcePRImageID");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ImageURL");
            entity.Property(e => e.SourcePrid).HasColumnName("SourcePRID");

            entity.HasOne(d => d.SourcePr).WithMany(p => p.SourcePrimages)
                .HasForeignKey(d => d.SourcePrid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SourcePRImage_SourcePR");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACF35EDBDE");

            entity.HasIndex(e => new { e.UserId, e.UserName }, "UC_User").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserLanguage).HasMaxLength(5);
            entity.Property(e => e.UserLogDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(20);
        });

        modelBuilder.Entity<UserAction>(entity =>
        {
            entity.ToTable("UserAction");

            entity.Property(e => e.UserActionId).HasColumnName("UserActionID");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VaddToHerme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VAddToHermes");

            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ItemUrl)
                .HasMaxLength(1700)
                .IsUnicode(false);
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.MainImage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductType)
                .HasMaxLength(64)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.Rate).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RubricId).HasColumnName("RubricID");
            entity.Property(e => e.Subscription)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ValidationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VarticleToValidate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VArticleToValidate");

            entity.Property(e => e.ArticleId).HasMaxLength(50);
            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.Author)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CountrydescFrench)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ExtractArticle).HasColumnType("text");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.IsOtherOrderArticle).HasColumnType("text");
            entity.Property(e => e.KeywordDescription).HasColumnType("text");
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.LangdescFrench)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Link)
                .HasMaxLength(1700)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.MediaName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.SelectionDate).HasColumnType("datetime");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.TextArticle).HasColumnType("text");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ValidatedBy).HasMaxLength(100);
            entity.Property(e => e.ValidationDate).HasColumnType("datetime");
            entity.Property(e => e.VisibilityKeywordDescription)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.VisibilityKeywordLocation)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VarticleToValidate2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VArticleToValidate2");

            entity.Property(e => e.ArticleId).HasMaxLength(50);
            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.Author)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CountrydescFrench)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ExtractArticle).HasColumnType("text");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.IsOtherOrderArticle).HasColumnType("text");
            entity.Property(e => e.KeywordDescription).HasColumnType("text");
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.LangdescFrench)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Link)
                .HasMaxLength(1700)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.MediaName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.SelectionDate).HasColumnType("datetime");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.TextArticle).HasColumnType("text");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ValidatedBy).HasMaxLength(100);
            entity.Property(e => e.ValidationDate).HasColumnType("datetime");
            entity.Property(e => e.VisibilityKeywordDescription)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.VisibilityKeywordLocation)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VarticlesOrderToTreat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VArticlesOrderToTreat");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.Customer)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.HitsValidated).HasColumnName("Hits_Validated");
            entity.Property(e => e.Lecteur).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.MapFlowId).HasColumnName("MapFlowID");
            entity.Property(e => e.MapLocationId).HasColumnName("MapLocationID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.Origine).HasMaxLength(255);
        });

        modelBuilder.Entity<VarticlesToCut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VArticlesToCut");

            entity.Property(e => e.ArticleSelectedId).HasColumnName("ArticleSelectedID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.CutId).HasColumnName("CutID");
            entity.Property(e => e.IsQa).HasColumnName("IsQA");
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.LockedBy).HasMaxLength(200);
            entity.Property(e => e.MainCaption)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MainImage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.MediaName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.RubricId).HasColumnName("RubricID");
            entity.Property(e => e.SelectionDate).HasColumnType("datetime");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.Summary)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(1700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vherme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VHermes");

            entity.Property(e => e.AlertDate).HasColumnType("datetime");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.MapMediaTypeId).HasColumnName("MapMediaTypeID");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.MediaName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MediaType)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.Url).IsUnicode(false);
            entity.Property(e => e.WordFound).IsUnicode(false);
        });

        modelBuilder.Entity<VlistOrdersCountArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VListOrdersCountArticles");

            entity.Property(e => e.Customer)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.LastHitsDate).HasColumnType("datetime");
            entity.Property(e => e.MapFlowId).HasColumnName("MapFlowID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderName)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AI");
        });

        modelBuilder.Entity<VrecupOpoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VRecupOpoint");

            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
        });

        modelBuilder.Entity<Vtalkwalker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VTalkwalker");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Fulltext).HasColumnName("FULLTEXT");
            entity.Property(e => e.Imageurl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IMAGEURL");
            entity.Property(e => e.Itemid)
                .ValueGeneratedOnAdd()
                .HasColumnName("itemid");
            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasColumnName("LANGUAGE");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Url)
                .HasMaxLength(1700)
                .IsUnicode(false);
            entity.Property(e => e.Words).HasColumnName("WORDS");
        });

        modelBuilder.Entity<VwebAlertKeyWordDescription>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWebAlertKeyWordDescription");

            entity.Property(e => e.KeywordDescHtmlfrweb).HasColumnName("KeywordDescHTMLFRWeb");
            entity.Property(e => e.KeywordDescHtmlnlweb).HasColumnName("KeywordDescHTMLNLWeb");
            entity.Property(e => e.KeywordLineId).HasColumnName("KeywordLineID");
            entity.Property(e => e.KeywordName)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.KeywordNameLine).UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<VwebGuruWaiting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWebGuruWaiting");

            entity.Property(e => e.InsertedDate)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwebTalkwalker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWeb_Talkwalker");

            entity.Property(e => e.Articletypename)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ARTICLETYPENAME");
            entity.Property(e => e.Category)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .UseCollation("French_CI_AS")
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Duration)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DURATION");
            entity.Property(e => e.Fulltext).HasColumnName("FULLTEXT");
            entity.Property(e => e.Imageurl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("IMAGEURL");
            entity.Property(e => e.Internatlsource)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("INTERNATLSOURCE");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Journalist)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS")
                .HasColumnName("JOURNALIST");
            entity.Property(e => e.Journalisturl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("JOURNALISTURL");
            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasColumnName("LANGUAGE");
            entity.Property(e => e.MapMediaTypeId).HasColumnName("MapMediaTypeID");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.Mediatype)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS")
                .HasColumnName("MEDIATYPE");
            entity.Property(e => e.Msneg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MSNEG");
            entity.Property(e => e.Msneu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MSNEU");
            entity.Property(e => e.Mspos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MSPOS");
            entity.Property(e => e.Mstot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MSTOT");
            entity.Property(e => e.Orderid)
                .HasMaxLength(255)
                .HasColumnName("ORDERID");
            entity.Property(e => e.Page)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PAGE");
            entity.Property(e => e.Publicationdate)
                .HasColumnType("datetime")
                .HasColumnName("PUBLICATIONDATE");
            entity.Property(e => e.Sourcename)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS")
                .HasColumnName("SOURCENAME");
            entity.Property(e => e.Subject)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SUBJECT");
            entity.Property(e => e.Subjectgroup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SUBJECTGROUP");
            entity.Property(e => e.Subsubject)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SUBSUBJECT");
            entity.Property(e => e.Surface)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SURFACE");
            entity.Property(e => e.Tags)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TAGS");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Tone)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TONE");
            entity.Property(e => e.Url)
                .HasMaxLength(1700)
                .IsUnicode(false)
                .HasColumnName("url");
            entity.Property(e => e.WebSite)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Words).HasColumnName("WORDS");
        });

        modelBuilder.Entity<WaitingSource>(entity =>
        {
            entity.ToTable("WaitingSource");

            entity.Property(e => e.WaitingSourceId).HasColumnName("WaitingSourceID");
            entity.Property(e => e.Author)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Lang).HasMaxLength(3);
            entity.Property(e => e.MainImage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MainSourceId).HasColumnName("MainSourceID");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .HasComment("= ISSUE de la table SourceOP ou Source")
                .HasColumnName("OPID");
            entity.Property(e => e.Prid).HasColumnName("PRID");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.SourceUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(2000);
            entity.Property(e => e.Url)
                .HasMaxLength(1700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WaitingSourceImage>(entity =>
        {
            entity.ToTable("WaitingSourceImage");

            entity.Property(e => e.WaitingSourceImageId).HasColumnName("WaitingSourceImageID");
            entity.Property(e => e.Caption).HasMaxLength(4000);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(1000)
                .HasColumnName("ImageURL");
            entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");
            entity.Property(e => e.WaitingSourceId).HasColumnName("WaitingSourceID");

            entity.HasOne(d => d.WaitingSource).WithMany(p => p.WaitingSourceImages)
                .HasForeignKey(d => d.WaitingSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WaitingSourceImage_WaitingSource");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
