using System;
using System.Collections.Generic;

namespace CopyDataToJson;

/// <summary>
/// Liste des langues (ISO 639-1)
/// </summary>
public partial class MapLanguage
{
    public long MapLanguageId { get; set; }

    public short? MediascoreId { get; set; }

    public string? JumboPilotId { get; set; }

    public string? CodeIso { get; set; }

    public string? DescFrench { get; set; }

    public string? DescDutch { get; set; }

    public string? DescEnglish { get; set; }

    public string? DescGerman { get; set; }

    public string? Description { get; set; }

    public int? ListOrder { get; set; }

    public bool? Active { get; set; }

    public string? CodeIso2 { get; set; }

    public string? NewbaseName { get; set; }
}
