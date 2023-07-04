using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class ArticleWordFound
{
    public long ArticleWordFoundId { get; set; }

    public long ArticleSelectedId { get; set; }

    public string? KeywordSource { get; set; }

    public string? KeywordFound { get; set; }

    public int? NbOfHits { get; set; }

    public virtual ArticleSelected ArticleSelected { get; set; } = null!;
}
