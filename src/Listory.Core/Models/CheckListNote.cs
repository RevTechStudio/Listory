namespace Listory.Core.Models;


/// <summary>
/// 項目に対する補足情報
/// </summary>
public class CheckListNote : CheckListBaseNote
{
    public Guid CheckListItemId { get; set; }
    public CheckListItem CheckListItem { get; set; } = null!;
}
