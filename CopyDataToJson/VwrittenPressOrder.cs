using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VwrittenPressOrder
{
    public int Orderid { get; set; }

    public string OrderName { get; set; } = null!;

    public string? ProfileName { get; set; }

    public string? ProfileAdditionFr { get; set; }

    public string? ProfileAdditionNl { get; set; }

    public bool Active { get; set; }
}
