using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Keyword
{
    public long KeywordId { get; set; }

    public int Orderid { get; set; }

    public string KeywordString { get; set; } = null!;

    public string? LaLanguageid { get; set; }

    public string KtTypeid { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModDate { get; set; }

    public string? ModBy { get; set; }

    public bool? Active { get; set; }

    public virtual MapKeywordType KtType { get; set; } = null!;
}
