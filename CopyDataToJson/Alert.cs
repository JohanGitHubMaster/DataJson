using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Alert
{
    public long AlertId { get; set; }

    public int OrderId { get; set; }

    public string? OrderName { get; set; }

    public long SourceId { get; set; }

    public DateTime AlertDate { get; set; }

    public string KeyWord { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool? Validated { get; set; }

    public string? ValidatedBy { get; set; }

    public DateTime? ValidationDate { get; set; }

    public bool? Sent { get; set; }

    public string WordFound { get; set; } = null!;

    public string? BlockUser { get; set; }

    public string Url { get; set; } = null!;

    public string? Lang { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? SourceName { get; set; }

    public string Issue { get; set; } = null!;

    public DateTime PublicationDate { get; set; }

    public string? SourceUrl { get; set; }

    public long? MediaId { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<AlertEmail> AlertEmails { get; set; } = new List<AlertEmail>();

    public virtual OrderDetail Order { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
