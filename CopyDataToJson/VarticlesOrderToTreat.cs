using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VarticlesOrderToTreat
{
    public int? CustomerId { get; set; }

    public string Customer { get; set; } = null!;

    public int OrderId { get; set; }

    public string OrderName { get; set; } = null!;

    public long WebPriority { get; set; }

    public long MapLocationId { get; set; }

    public string? Location { get; set; }

    public long MapFlowId { get; set; }

    public string? Origine { get; set; }

    public int Hits { get; set; }

    public int Treat { get; set; }

    public int HitsValidated { get; set; }

    public string? Lecteur { get; set; }

    public string Active { get; set; } = null!;
}
