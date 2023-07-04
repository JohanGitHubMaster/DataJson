using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class KeywordCondition
{
    public long KeywordConditionId { get; set; }

    public long KeywordLineId { get; set; }

    public string KcConditionTypeid { get; set; } = null!;

    public string KeywordConditionName { get; set; } = null!;

    public int? NbOfWords { get; set; }

    public int? ListOrder { get; set; }

    public string? Keyword { get; set; }

    public virtual MapConditionType KcConditionType { get; set; } = null!;

    public virtual KeywordLine KeywordLine { get; set; } = null!;
}
