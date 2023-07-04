using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class ProfilOther
{
    public int? OrderId { get; set; }

    public string OrderName { get; set; } = null!;

    public int? CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public long ArticleSelectedId { get; set; }

    public bool Validated { get; set; }

    public long OrderSettingsId { get; set; }

    public long SourceId { get; set; }

    public long WebPriority { get; set; }

    public string? Lang { get; set; }

    public string? Text { get; set; }
}
