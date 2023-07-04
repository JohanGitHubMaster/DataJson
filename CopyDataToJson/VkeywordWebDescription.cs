using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VkeywordWebDescription
{
    public int Orderid { get; set; }

    public long KeywordLineId { get; set; }

    public long? KeywordDescriptionId { get; set; }

    public string? Keyword { get; set; }

    public int? MinHits { get; set; }

    public string? KeywordDescHtmlfrweb { get; set; }

    public string? KeywordDescHtmlnlweb { get; set; }

    public int ListOrder { get; set; }

    public string IsVisible { get; set; } = null!;

    public string? ConditionTypeName { get; set; }

    public string? NbOfWordsCondition { get; set; }

    public string KcConditionTypeid { get; set; } = null!;

    public int? NumberOfCondition { get; set; }
}
