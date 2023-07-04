using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class KeywordDescription
{
    public long KeywordDescriptionId { get; set; }

    public long KeywordLineId { get; set; }

    public string KeywordName { get; set; } = null!;

    public string? KeywordDescFr { get; set; }

    public string? KeywordDescNl { get; set; }

    public string? KeywordDescHtmlfr { get; set; }

    public string? KeywordDescHtmlnl { get; set; }

    public string? KeywordWebDescriptionHtml { get; set; }

    public string? KeywordDescHtmlfrweb { get; set; }

    public string? KeywordDescHtmlnlweb { get; set; }

    public virtual KeywordLine KeywordLine { get; set; } = null!;
}
