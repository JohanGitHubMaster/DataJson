using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class SourcePrimage
{
    public long SourcePrimageId { get; set; }

    public long SourcePrid { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int ImageIndex { get; set; }

    public bool IsValid { get; set; }

    public virtual SourcePr SourcePr { get; set; } = null!;
}
