using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VaddToHerme
{
    public long ArticleSelectedId { get; set; }

    public long MapItemTypeid { get; set; }

    public string? Title { get; set; }

    public DateTime? PublicationDate { get; set; }

    public DateTime? ValidationDate { get; set; }

    public string? ItemUrl { get; set; }

    public string? Lang { get; set; }

    public long? RubricId { get; set; }

    public bool Validated { get; set; }

    public int? Circulation { get; set; }

    public int? Audience { get; set; }

    public decimal? Rate { get; set; }

    public long MediaId { get; set; }

    public long? ContactId { get; set; }

    public string? FullText { get; set; }

    public int OrderId { get; set; }

    public string? Subscription { get; set; }

    public string? ProductType { get; set; }

    public string? MainImage { get; set; }

    public string? Keywords { get; set; }
}
