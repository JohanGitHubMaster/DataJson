using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class MapConditionType
{
    public long MapConditionTypeId { get; set; }

    public string KcConditionTypeid { get; set; } = null!;

    public string? DescFrench { get; set; }

    public string? DescDutch { get; set; }

    public string? DescEnglish { get; set; }

    public string? DescGerman { get; set; }

    public string? Description { get; set; }

    public bool? Groupable { get; set; }

    public int? ListOrder { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<KeywordCondition> KeywordConditions { get; set; } = new List<KeywordCondition>();
}
