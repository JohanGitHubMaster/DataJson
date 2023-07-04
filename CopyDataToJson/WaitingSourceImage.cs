using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class WaitingSourceImage
{
    public long WaitingSourceImageId { get; set; }

    public long WaitingSourceId { get; set; }

    public string? ImageUrl { get; set; }

    public int? ImageIndex { get; set; }

    public string? Caption { get; set; }

    public bool? IsValid { get; set; }

    public virtual WaitingSource WaitingSource { get; set; } = null!;
}
