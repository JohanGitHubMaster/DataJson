using System;
using System.Collections.Generic;

namespace CopyDataToJson;

/// <summary>
/// Liste des pays (ISO 3166-1)
/// </summary>
public partial class MapCountry
{
    public long MapCountryId { get; set; }

    public short? MediascoreId { get; set; }

    public string? JumboPilotId { get; set; }

    public string? CodeIso2 { get; set; }

    public string? CodeIso3 { get; set; }

    public string? DescFrench { get; set; }

    public string? DescDutch { get; set; }

    public string? DescEnglish { get; set; }

    public string? DescGerman { get; set; }

    public int? ListOrder { get; set; }

    public bool? Active { get; set; }
}
