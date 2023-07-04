using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class SourceOpimage
{
    public long SourceOpimageId { get; set; }

    public long SourceOpid { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int ImageIndex { get; set; }

    public string? Caption { get; set; }

    public bool? IsValid { get; set; }

    public virtual SourceOp SourceOp { get; set; } = null!;
}
