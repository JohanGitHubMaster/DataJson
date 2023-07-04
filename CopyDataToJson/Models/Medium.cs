using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CopyDataToJson.Models;

/// <summary>
/// Les sources (publications)
/// </summary>
[Index("MapCountryId", "Active", Name = "IDX_Media_MapCountryID_Active")]
[Index("MapMediaTypeId", "Active", "Guru", Name = "IX_MapMediaTypeID_Active_GURU")]
[Index("MediaId", "JumboPilotId", Name = "IX_MediaID_JumboPilotID")]
[Index("MediaName", Name = "IX_MediaName", IsUnique = true)]
[Index("MediaName", Name = "IX_MediaSummary")]
[Index("Active", "Guru", "MapCountryId", "MapMediaTypeId", Name = "IX_Media_Active_Guru_MapCountryID_MapMediaTypeID")]
[Index("Guru", Name = "IX_Media_Guru")]
[Index("MediaId", Name = "IX_Media_IDs")]
[Index("Linkid", Name = "IX_Media_Linkid")]
[Index("MapCountryId", "Active", "Guru", "MapMediaTypeId", Name = "IX_Media_MapCountryID_Active_Guru_MapMediaTypeID")]
[Index("MapCountryId", "MapMediaTypeId", "Active", "Guru", Name = "IX_Media_MapCountryID_MapMediaTypeID_Active_Guru")]
[Index("MapMediaTypeId", "Active", "Guru", "MapCalendarTypeId", Name = "IX_Media_MapMediaTypeID_Active_Guru_MapCalendarTypeID")]
[Index("MapMediaTypeId", "Active", "Guru", "MapCountryId", Name = "IX_Media_MapMediaTypeID_Active_Guru_MapCountryID")]
[Index("MapMediaTypeId", "Active", "Guru", "MediaId", "MapCalendarTypeId", Name = "IX_Media_MapMediaTypeID_Active_Guru_MediaID_MapCalendarTypeID")]
[Index("MapPeriodicityId", "Guru", Name = "IX_Media_MapPeriodicityID_Guru")]
[Index("MediaId", Name = "IX_Media_MediaID")]
[Index("MediaId", "ParentId", Name = "IX_Media_MediaIDParentID")]
[Index("MapPeriodicityId", "MapCountryId", "MapMediaTypeId", Name = "IX_Media_Multiple")]
[Index("PrnewswireId", "MediaId", Name = "IX_Media_Multiple2")]
[Index("MediaId", "ParentId", Name = "IX_Media_ParentID")]
[Index("UpdateJp", Name = "IX_Media_UpdateJP")]
[Index("UpdateMs", Name = "IX_Media_UpdateMS")]
[Index("MapMediaTypeId", Name = "IdxMediaMediatype")]
[Index("JumboPilotId", Name = "SQLTRINX_Media_JumboPilotID")]
[Index("JumboPilotId", Name = "SQLTRINX_Media_JumboPilotID_Includes")]
[Index("ParentId", Name = "SQLTRINX_Media_ParentID_Includes")]
[Index("UpdateFigureJp", Name = "SQLTRINX_Media_UpdateFigureJP_Includes")]
[Index("UpdateGroupJp", Name = "SQLTRINX_Media_UpdateGroupJP_Includes")]
[Index("UpdateLanguageJp", Name = "SQLTRINX_Media_UpdateLanguageJP_Includes")]
[Index("Active", "MapMediaTypeId", "MapCountryId", Name = "_dta_index_Media_13_1158295186__K27_K19_K17_1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_18_20_21_22_23_24_25_26_28_29_30_31_32_33_")]
public partial class Medium
{
    [Key]
    [Column("MediaID")]
    public long MediaId { get; set; }

    [Column("PRNewswireID")]
    [StringLength(255)]
    public string? PrnewswireId { get; set; }

    [Column("JumboPilotID")]
    public int? JumboPilotId { get; set; }

    [Column("MediaScoreID")]
    public int? MediaScoreId { get; set; }

    [StringLength(255)]
    public string? MediaName { get; set; }

    [Required]
    public bool? DigitalRights { get; set; }

    public bool MorningInfo { get; set; }

    [StringLength(255)]
    public string? AddressLine1 { get; set; }

    [StringLength(255)]
    public string? AddressLine2 { get; set; }

    [StringLength(255)]
    public string? PostalCode { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    [StringLength(255)]
    public string? WebSite { get; set; }

    [StringLength(255)]
    public string? PhoneNumber { get; set; }

    [StringLength(255)]
    public string? FaxNumber { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    public string? Description { get; set; }

    [Column("MapCountryID")]
    public long? MapCountryId { get; set; }

    [Column("MapPeriodicityID")]
    public long? MapPeriodicityId { get; set; }

    [Column("MapMediaTypeID")]
    public long? MapMediaTypeId { get; set; }

    [Column("MapFormatID")]
    public long? MapFormatId { get; set; }

    [Column("MapCategoryID")]
    public long? MapCategoryId { get; set; }

    [Column("MapCalendarTypeID")]
    public long? MapCalendarTypeId { get; set; }

    [Column("MapDeliveryMethodID")]
    public long? MapDeliveryMethodId { get; set; }

    [Column("MapFocusID")]
    public long? MapFocusId { get; set; }

    [Column("PublisherID")]
    public long? PublisherId { get; set; }

    public string? Remarks { get; set; }

    [Required]
    public bool? Active { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModDate { get; set; }

    [Column("UpdateMS")]
    public bool UpdateMs { get; set; }

    [Column("UpdateJP")]
    public bool UpdateJp { get; set; }

    [Column("UpdateLanguageJP")]
    public bool UpdateLanguageJp { get; set; }

    [Column("UpdateFigureJP")]
    public bool UpdateFigureJp { get; set; }

    [Column("UpdateFigureMS")]
    public bool UpdateFigureMs { get; set; }

    [Column("UpdateGroupJP")]
    public bool UpdateGroupJp { get; set; }

    [Required]
    [Column("ActiveJP")]
    public bool? ActiveJp { get; set; }

    [Required]
    [Column("ActiveMS")]
    public bool? ActiveMs { get; set; }

    [StringLength(255)]
    public string? CreatedBy { get; set; }

    [StringLength(255)]
    public string? ModBy { get; set; }

    [Column("ParentID")]
    public long? ParentId { get; set; }

    public bool RefreshAllFigures { get; set; }

    public int? SeqLength { get; set; }

    public short? NbOfCuttings { get; set; }

    public short? Priority { get; set; }

    [Precision(0)]
    public TimeSpan? StartTime { get; set; }

    [Precision(0)]
    public TimeSpan? EndTime { get; set; }

    public short? Texthandling { get; set; }

    [Column("RealPDF")]
    public short? RealPdf { get; set; }

    public bool? GoPress { get; set; }

    public bool? PublicationMaster { get; set; }

    public bool? Up2News { get; set; }

    public bool Guru { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Linkid { get; set; }

    public bool Integral { get; set; }

    [Column("MapMasterProviderID")]
    public int? MapMasterProviderId { get; set; }
}
