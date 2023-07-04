using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VorderWebWithPriority
{
    public string OrderName { get; set; } = null!;

    public int? OrderId { get; set; }

    public long SourceId { get; set; }

    public string Customer { get; set; } = null!;

    public string? ProfileAdditionHtmlfrweb { get; set; }

    public string? ProfileAdditionHtmlnlweb { get; set; }

    public long? WebPriority { get; set; }

    public long ArticleSelectedId { get; set; }

    public bool Validated { get; set; }

    public bool? Lock { get; set; }

    public string? KeywordFoundandhits { get; set; }

    public string? KeywordFound { get; set; }

    public string? KeywordSource { get; set; }

    public string? Location { get; set; }

    public int? IsOk { get; set; }

    public int? IsNotOk { get; set; }

    public string? TextExtractOtherCommand { get; set; }
}
