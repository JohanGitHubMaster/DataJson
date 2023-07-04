using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VordersKeyword
{
    public long KeywordId { get; set; }

    public int Orderid { get; set; }

    public string KeywordString { get; set; } = null!;

    public string? LaLanguageid { get; set; }

    public string KtTypeid { get; set; } = null!;

    public string LanguageName { get; set; } = null!;
}
