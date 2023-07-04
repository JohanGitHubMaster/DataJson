using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class SourceOp
{
    public long SourceOpid { get; set; }

    public string? FilePath { get; set; }

    public string ArticleId { get; set; } = null!;

    public DateTime? InsertedDate { get; set; }

    public string? Lang { get; set; }

    public string? Country { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public DateTime? PublicationDate { get; set; }

    public string? Url { get; set; }

    public int? WordCount { get; set; }

    public string? MainImage { get; set; }

    public string? Summary { get; set; }

    public string? MainCaption { get; set; }

    public string? SourceUrl { get; set; }

    public string? Issue { get; set; }

    public string? Author { get; set; }

    public long? MediaId { get; set; }

    public long? ContactId { get; set; }

    public bool? Paywall { get; set; }

    public long? MainSourceId { get; set; }

    public virtual MainSource? MainSource { get; set; }

    public virtual ICollection<SourceOpimage> SourceOpimages { get; set; } = new List<SourceOpimage>();
}
