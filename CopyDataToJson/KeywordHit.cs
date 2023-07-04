using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class KeywordHit
{
    public long KeywordHitId { get; set; }

    public long KeywordLineId { get; set; }

    public string KeywordName { get; set; } = null!;

    public int MinHits { get; set; }

    public virtual KeywordLine KeywordLine { get; set; } = null!;
}
