using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class KeywordLine
{
    public long KeywordLineId { get; set; }

    public long KeywordGroupId { get; set; }

    public string KeywordName { get; set; } = null!;

    public bool? KeywordInclude { get; set; }

    public int? ListOrder { get; set; }

    public bool KeywordAllKeywords { get; set; }

    public bool? Active { get; set; }

    public bool FromDateActive { get; set; }

    public DateTime? FromDate { get; set; }

    public bool ToDateActive { get; set; }

    public DateTime? ToDate { get; set; }

    public bool HeaderOnly { get; set; }

    public virtual ICollection<KeywordCondition> KeywordConditions { get; set; } = new List<KeywordCondition>();

    public virtual ICollection<KeywordDescription> KeywordDescriptions { get; set; } = new List<KeywordDescription>();

    public virtual KeywordGroup KeywordGroup { get; set; } = null!;

    public virtual ICollection<KeywordHit> KeywordHits { get; set; } = new List<KeywordHit>();
}
