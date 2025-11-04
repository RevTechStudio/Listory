namespace Listory.Core.Models;


/// <summary>
/// 項目に対する参照情報（手順書的な補足）
/// </summary>
public class CheckListReferenceNote : CheckListBaseNote
{
    public Guid CheckListItemId { get; set; }
    public CheckListItem CheckListItem { get; set; } = null!;
}
