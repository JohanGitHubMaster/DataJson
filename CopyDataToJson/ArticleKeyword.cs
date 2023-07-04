using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class ArticleKeyword
{
    public long ArticleKeywordId { get; set; }

    public long ArticleSelectedId { get; set; }

    public string? Extract { get; set; }

    public string? ExtractKeyword { get; set; }

    public int? ListOrder { get; set; }

    public virtual ArticleSelected ArticleSelected { get; set; } = null!;
}
