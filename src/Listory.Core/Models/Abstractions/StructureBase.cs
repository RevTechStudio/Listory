using Listory.Core.Models.Entities;

namespace Listory.Core.Models.Abstractions;

/// <summary>
/// 構成情報の基底となる抽象クラス
/// </summary>
/// <typeparam name="TStructure">継承する具象クラスの型</typeparam>
public abstract class StructureBase<TStructure>
    where TStructure : StructureBase<TStructure>
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

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
    public TStructure? ParentStructure { get; set; }

    /// <summary>
    /// 子構成リスト
    /// </summary>
    public ICollection<TStructure> ChildStructures { get; set; } = [];

    /// <summary>
    /// 同一親内での表示順序(0始まり)
    /// </summary>
    public int Order { get; set; }
}
