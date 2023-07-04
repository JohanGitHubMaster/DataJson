using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VwebAlertKeyWordDescription
{
    public long KeywordLineId { get; set; }

    public string KeywordNameLine { get; set; } = null!;

    public string KeywordName { get; set; } = null!;

    public string? KeywordDescHtmlfrweb { get; set; }

    public string? KeywordDescHtmlnlweb { get; set; }

    public int Orderid { get; set; }
}
