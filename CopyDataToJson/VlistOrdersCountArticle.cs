using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VlistOrdersCountArticle
{
    public long WebPriority { get; set; }

    public long MapFlowId { get; set; }

    public int? OrderId { get; set; }

    public string OrderName { get; set; } = null!;

    public int? CustomerId { get; set; }

    public string Customer { get; set; } = null!;

    public DateTime? LastHitsDate { get; set; }

    public int? CountArticles { get; set; }
}
