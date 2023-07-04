using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VarticlesToCut
{
    public long ArticleSelectedId { get; set; }

    public int OrderId { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? Url { get; set; }

    public string? Summary { get; set; }

    public string? MainImage { get; set; }

    public string? MainCaption { get; set; }

    public DateTime? PublicationDate { get; set; }

    public DateTime? SelectionDate { get; set; }

    public string? Country { get; set; }

    public string? Lang { get; set; }

    public int CutId { get; set; }

    public string? Keywords { get; set; }

    public long SourceId { get; set; }

    public long? MediaId { get; set; }

    public string? MediaName { get; set; }

    public int? CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string OrderName { get; set; } = null!;

    public long? ContactId { get; set; }

    public string? Comment { get; set; }

    public long? RubricId { get; set; }

    public bool IsQa { get; set; }

    public int? Rubrics { get; set; }

    public bool LockedForCut { get; set; }

    public string? LockedBy { get; set; }
}
