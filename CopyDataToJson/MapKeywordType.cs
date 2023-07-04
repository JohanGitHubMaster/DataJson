using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class MapKeywordType
{
    public long MapKeywordTypeId { get; set; }

    public string KtTypeid { get; set; } = null!;

    public string? DescFrench { get; set; }

    public string? DescDutch { get; set; }

    public string? DescEnglish { get; set; }

    public string? DescGerman { get; set; }

    public string? Description { get; set; }

    public int? ListOrder { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<KeywordGroup> KeywordGroups { get; set; } = new List<KeywordGroup>();

    public virtual ICollection<Keyword> Keywords { get; set; } = new List<Keyword>();
}
