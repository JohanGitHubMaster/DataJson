using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class MapLocation
{
    public long MapLocationId { get; set; }

    public string? DescFrench { get; set; }

    public string? DescDutch { get; set; }

    public string? DescEnglish { get; set; }

    public string? DescGerman { get; set; }

    public string? Description { get; set; }

    public int? ListOrder { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<OrderSetting> OrderSettings { get; set; } = new List<OrderSetting>();
}
