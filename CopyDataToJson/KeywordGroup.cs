using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class KeywordGroup
{
    public long KeywordGroupId { get; set; }

    public string? LaLanguageid { get; set; }

    public int Orderid { get; set; }

    public int? ListOrder { get; set; }

    public string? KtTypeid { get; set; }

    public virtual ICollection<KeywordLine> KeywordLines { get; set; } = new List<KeywordLine>();

    public virtual MapKeywordType? KtType { get; set; }
}
