using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VwebTalkwalker
{
    public long Itemid { get; set; }

    public long MapMediaTypeId { get; set; }

    public long MediaId { get; set; }

    public string? Url { get; set; }

    public string? Orderid { get; set; }

    public string Internatlsource { get; set; } = null!;

    public string? Sourcename { get; set; }

    public string? Title { get; set; }

    public DateTime? Publicationdate { get; set; }

    public string? Fulltext { get; set; }

    public string Page { get; set; } = null!;

    public string? Journalist { get; set; }

    public string Journalisturl { get; set; } = null!;

    public string Surface { get; set; } = null!;

    public string Duration { get; set; } = null!;

    public int Words { get; set; }

    public string? Mediatype { get; set; }

    public string Subjectgroup { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Subsubject { get; set; } = null!;

    public string Articletypename { get; set; } = null!;

    public string? Country { get; set; }

    public string? Language { get; set; }

    public string Tone { get; set; } = null!;

    public string Mspos { get; set; } = null!;

    public string Msneu { get; set; } = null!;

    public string Msneg { get; set; } = null!;

    public string Mstot { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string? WebSite { get; set; }

    public string? Imageurl { get; set; }

    public string Tags { get; set; } = null!;
}
