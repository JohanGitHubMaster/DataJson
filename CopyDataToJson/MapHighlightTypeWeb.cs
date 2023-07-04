using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class MapHighlightTypeWeb
{
    public long MapHighlightTypeWebId { get; set; }

    public string Code { get; set; } = null!;

    public string? DescFrench { get; set; }

    public string? DescDutch { get; set; }

    public string? DescEnglish { get; set; }

    public string? DescGerman { get; set; }

    public int? ListOrder { get; set; }

    public bool? Active { get; set; }
}
