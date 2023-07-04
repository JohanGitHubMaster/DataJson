using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VarticleToValidate
{
    public bool Isvalid { get; set; }

    public bool IsNotvalid { get; set; }

    public string? IsOtherOrderArticle { get; set; }

    public long SourceId { get; set; }

    public string? MediaName { get; set; }

    public DateTime? PublicationDate { get; set; }

    public string? Title { get; set; }

    public string? Country { get; set; }

    public string? Lang { get; set; }

    public string? FullName { get; set; }

    public DateTime? SelectionDate { get; set; }

    public string? ArticleId { get; set; }

    public string? Link { get; set; }

    public string? Comment { get; set; }

    public bool Validated { get; set; }

    public int? OrderId { get; set; }

    public long? MediaId { get; set; }

    public long? ArticleSelectedId { get; set; }

    public string? ValidatedBy { get; set; }

    public DateTime? ValidationDate { get; set; }

    public bool ToTreat { get; set; }

    public string? TextArticle { get; set; }

    public string? ExtractArticle { get; set; }

    public string? TextArticleSource { get; set; }

    public int WordCount { get; set; }

    public string? Author { get; set; }

    public string? KeywordFound { get; set; }

    public string? KeywordFoundandhits { get; set; }

    public string? KeywordDescription { get; set; }

    public string? LangdescFrench { get; set; }

    public string? CountrydescFrench { get; set; }

    public string VisibilityKeywordDescription { get; set; } = null!;

    public string VisibilityKeywordLocation { get; set; } = null!;

    public string? KeywordSource { get; set; }

    public string? KeywordExtract { get; set; }

    public string? Location { get; set; }
}
