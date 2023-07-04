using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class SourceImage
{
    public long SourceImageId { get; set; }

    public long SourceId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int ImageIndex { get; set; }

    public string? Caption { get; set; }

    public bool? IsValid { get; set; }

    public virtual Source Source { get; set; } = null!;
}
