using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VminHitsWeb
{
    public long KeywordGroupId { get; set; }

    public long KeywordLineId { get; set; }

    public long? KeywordHitId { get; set; }

    public int Orderid { get; set; }

    public string? KeywordName { get; set; }

    public int? MinHits { get; set; }

    public bool HeaderOnly { get; set; }
}
