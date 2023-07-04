using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Source
{
    public long SourceId { get; set; }

    public string? FilePath { get; set; }

    public byte? Status { get; set; }

    public DateTime? InsertedDate { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public string? Lang { get; set; }

    public bool ForWebAlert { get; set; }

    public bool ForGuru { get; set; }

    public string? Type { get; set; }

    public string? Country { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? ArticleId { get; set; }

    public DateTime? PublicationDate { get; set; }

    public string? Url { get; set; }

    public int WordCount { get; set; }

    public string? MainImage { get; set; }

    public string? Summary { get; set; }

    public string? MainCaption { get; set; }

    public string? SourceUrl { get; set; }

    public string? Issue { get; set; }

    public string? Author { get; set; }

    public long? MediaId { get; set; }

    public long? ContactId { get; set; }

    public bool Paywall { get; set; }

    public long? MainSourceId { get; set; }

    public byte? Status2 { get; set; }

    public bool LockedForCut { get; set; }

    public string? LockedBy { get; set; }

    public bool? ToTalkwalker { get; set; }

    public long? Prid { get; set; }

    public bool? FromProvider { get; set; }

    public int? ProviderId { get; set; }

    //public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    //public virtual ICollection<ArticleSelected> ArticleSelecteds { get; set; } = new List<ArticleSelected>();

    //public virtual ICollection<SourceImage> SourceImages { get; set; } = new List<SourceImage>();
}
