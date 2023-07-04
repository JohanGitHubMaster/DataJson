using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VordersRubric
{
    public string Customer { get; set; } = null!;

    public string OrderName { get; set; } = null!;

    public int? OrderId { get; set; }

    public string Rubric { get; set; } = null!;
}
