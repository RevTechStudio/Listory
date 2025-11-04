namespace Listory.Core.Models.Entities;

/// <summary>
/// チェックリストの構成情報
/// </summary>
public class CheckListStructure
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// 所属するチェックリストID
    /// </summary>
    public Guid CheckListId { get; set; }

    /// <summary>
    /// チェックリストへの参照
    /// </summary>
    public CheckList CheckList { get; set; } = null!;

    /// <summary>
    /// チェック項目ID
    /// </summary>
    public Guid CheckListItemId { get; set; }

    /// <summary>
    /// チェック項目への参照
    /// </summary>
    public CheckListItem CheckListItem { get; set; } = null!;

    /// <summary>
    /// 親ノードのID
    /// </summary>
    public Guid? ParentStructureId { get; set; }

    /// <summary>
    /// 親構成への参照
    /// </summary>
    public CheckListStructure? ParentStructure { get; set; }

    /// <summary>
    /// 子構成リスト
    /// </summary>
    public ICollection<CheckListStructure> ChildStructures { get; set; } = [];

    /// <summary>
    /// 記録情報
    /// </summary>
    public CheckListLogNote? LogNote { get; set; }

    /// <summary>
    /// チェック状態
    /// </summary>
    public bool IsCompleted { get; set; } = false;

    /// <summary>
    /// チェック日時
    /// </summary>
    public DateTime? CompletedAt { get; set; }
    
    /// <summary>
    /// チェック者
    /// </summary>
    public string? CompletedBy { get; set; }
}
