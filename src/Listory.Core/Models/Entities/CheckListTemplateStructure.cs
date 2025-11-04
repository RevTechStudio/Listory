namespace Listory.Core.Models.Entities;

/// <summary>
/// チェックリストテンプレートの構成情報
/// </summary>
public class CheckListTemplateStructure
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// 所属するチェックリストテンプレートID
    /// </summary>
    public Guid CheckListTemplateId { get; set; }

    /// <summary>
    /// チェックリストテンプレートへの参照
    /// </summary>
    public CheckListTemplate CheckListTemplate { get; set; } = null!;

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
    public CheckListTemplateStructure? ParentStructure { get; set; }

    /// <summary>
    /// 子構成リスト
    /// </summary>
    public ICollection<CheckListTemplateStructure> ChildStructures { get; set; } = [];
}
