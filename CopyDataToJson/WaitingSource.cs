using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class WaitingSource
{
    public long WaitingSourceId { get; set; }

    public string? FilePath { get; set; }

    /// <summary>
    /// = ISSUE de la table SourceOP ou Source
    /// </summary>
    public string? Opid { get; set; }

    public long? Prid { get; set; }

    public DateTime InsertedDate { get; set; }

    public string? Lang { get; set; }

    public string? Country { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public DateTime PublicationDate { get; set; }

    public string Url { get; set; } = null!;

    public int? WordCount { get; set; }

    public string? MainImage { get; set; }

    public string? SourceUrl { get; set; }

    public string? Author { get; set; }

    public long? MediaId { get; set; }

    public long? ContactId { get; set; }

    public bool? Paywall { get; set; }

    public long? MainSourceId { get; set; }

    public virtual ICollection<WaitingSourceImage> WaitingSourceImages { get; set; } = new List<WaitingSourceImage>();
}
