using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Vtalkwalker
{
    public long Itemid { get; set; }

    public string? Title { get; set; }

    public string? Language { get; set; }

    public int Words { get; set; }

    public DateTime? PublicationDate { get; set; }

    public string? Fulltext { get; set; }

    public string? Url { get; set; }

    public long? MediaId { get; set; }

    public long? ContactId { get; set; }

    public string? Imageurl { get; set; }
}
