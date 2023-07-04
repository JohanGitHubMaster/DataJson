using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class MainSource
{
    public long MainSourceId { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public string? SiteName { get; set; }

    public string? SiteUrl { get; set; }

    public long? MediaId { get; set; }

    public DateTime? CreationDate { get; set; }

    public virtual ICollection<SourceOp> SourceOps { get; set; } = new List<SourceOp>();
}
