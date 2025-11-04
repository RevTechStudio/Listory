using Listory.Core.Models.Abstractions;

namespace Listory.Core.Models.Entities;

/// <summary>
/// チェック項目に対する参照情報（手順書的な補足）
/// </summary>
public class CheckListReferenceNote : CheckListBaseNote
{
    /// <summary>
    /// チェック項目ID
    /// </summary>
    public Guid CheckListItemId { get; set; }
    
    /// <summary>
    /// チェック項目への参照
    /// </summary>
    public CheckListItem CheckListItem { get; set; } = null!;
}
