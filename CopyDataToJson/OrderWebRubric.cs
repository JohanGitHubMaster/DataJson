using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class OrderWebRubric
{
    public long OrderWebRubricId { get; set; }

    public int Orderid { get; set; }

    public string Rubric { get; set; } = null!;

    public bool? Active { get; set; }
}
