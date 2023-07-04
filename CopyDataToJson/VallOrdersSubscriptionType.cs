using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VallOrdersSubscriptionType
{
    public int? OrderId { get; set; }

    public string OrderName { get; set; } = null!;

    public int? CustomerId { get; set; }

    public string Customer { get; set; } = null!;

    public double KProject { get; set; }

    public bool? Active { get; set; }
}
