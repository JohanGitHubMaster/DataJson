using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class ArticleSelected
{
    public long ArticleSelectedId { get; set; }

    public int OrderId { get; set; }

    public long SourceId { get; set; }

    public DateTime? SelectionDate { get; set; }

    public bool? ToTreat { get; set; }

    public bool Validated { get; set; }

    public string? ValidatedBy { get; set; }

    public DateTime? ValidationDate { get; set; }

    public int Cut { get; set; }

    public string? CutBy { get; set; }

    public DateTime? CutDate { get; set; }

    public string? Comment { get; set; }

    public long? RubricId { get; set; }

    public long? CutType { get; set; }

    public int Uivalidated { get; set; }

    public bool? FromWebFindSvc { get; set; }

    public virtual ICollection<ArticleKeyword> ArticleKeywords { get; set; } = new List<ArticleKeyword>();

    public virtual ICollection<ArticleWordFound> ArticleWordFounds { get; set; } = new List<ArticleWordFound>();

    public virtual Source Source { get; set; } = null!;
}
