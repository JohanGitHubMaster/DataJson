using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Vreport
{
    public long KeywordGroupId { get; set; }

    public string? LaLanguageid { get; set; }

    public int Orderid { get; set; }

    public string? KtTypeid { get; set; }

    public long KeywordLineId { get; set; }

    public string KeywordName { get; set; } = null!;

    public bool KeywordInclude { get; set; }

    public bool KeywordAllKeywords { get; set; }
}
