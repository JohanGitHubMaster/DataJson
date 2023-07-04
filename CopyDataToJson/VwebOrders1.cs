using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VwebOrders1
{
    public int? OrderId { get; set; }

    public string OrderName { get; set; } = null!;

    public int? CustomerId { get; set; }

    public string Customer { get; set; } = null!;

    public double KProject { get; set; }

    public string Active { get; set; } = null!;

    public DateTime? DateEnd { get; set; }
}
