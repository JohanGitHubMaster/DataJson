using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Vkeyword
{
    public int Orderid { get; set; }

    public long KeywordGroupId { get; set; }

    public string? LaLanguageid { get; set; }

    public string? LanguageName { get; set; }

    public int? NbOfKeywords { get; set; }

    public long KeywordLineId { get; set; }

    public string KeywordName { get; set; } = null!;

    public bool? KeywordInclude { get; set; }

    public int? NbOfConditions { get; set; }

    public string KcConditionTypeid { get; set; } = null!;

    public string? Keyword { get; set; }

    public string ConditionName { get; set; } = null!;

    public string KeywordConditionName { get; set; } = null!;

    public int? NbOfWords { get; set; }

    public long KeywordConditionId { get; set; }

    public int? ListOrder1 { get; set; }

    public int? ListOrder2 { get; set; }

    public int? ListOrder3 { get; set; }

    public string? KtTypeid { get; set; }

    public bool? KeywordAllKeywords { get; set; }

    public bool? HeaderOnly { get; set; }

    public bool Active { get; set; }

    public bool FromDateActive { get; set; }

    public DateTime? FromDate { get; set; }

    public bool ToDateActive { get; set; }

    public DateTime? ToDate { get; set; }

    public string? CodeIso2 { get; set; }
}
