namespace Listory.Core.Models;


/// <summary>
/// チェックリストの構成情報
/// </summary>
public class CheckListStructure
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid CheckListId { get; set; }
    public CheckList CheckList { get; set; } = null!;

    public Guid CheckListItemId { get; set; }
    public CheckListItem CheckListItem { get; set; } = null!;

    // 階層構造
    public Guid? ParentStructureId { get; set; }
    public CheckListStructure? ParentStructure { get; set; }
    public ICollection<CheckListStructure> ChildStructures { get; set; } = [];

    // 記録情報
    public CheckListRecord Record { get; set; } = new();

    // 状態情報
    public bool IsChecked { get; set; }
    public DateTime? CompletedAt { get; set; }
    public string? CompletedBy { get; set; }
}
