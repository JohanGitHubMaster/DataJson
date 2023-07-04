using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class SourcePr
{
    public long SourcePrid { get; set; }

    public string? FilePath { get; set; }

    public long? Prid { get; set; }

    public string Url { get; set; } = null!;

    public long? MediaPrid { get; set; }

    public long? MediaId { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? Lang { get; set; }

    public bool Checked { get; set; }

    public byte? Status2 { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public DateTime? PublicationDate { get; set; }

    public DateTime? InsertionDate { get; set; }

    public string? MainImage { get; set; }

    public long? ContactId { get; set; }

    public int? WordCount { get; set; }

    public string? Author { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<SourcePrimage> SourcePrimages { get; set; } = new List<SourcePrimage>();
}
