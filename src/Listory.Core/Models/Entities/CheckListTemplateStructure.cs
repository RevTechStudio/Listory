using Listory.Core.Models.Abstractions;

namespace Listory.Core.Models.Entities;

/// <summary>
/// チェックリストテンプレートの構成情報
/// </summary>
public class CheckListTemplateStructure : StructureBase<CheckListTemplateStructure>
{
    /// <summary>
    /// 所属するチェックリストテンプレートID
    /// </summary>
    public Guid CheckListTemplateId { get; set; }

    /// <summary>
    /// チェックリストテンプレートへの参照
    /// </summary>
    public CheckListTemplate CheckListTemplate { get; set; } = null!;
}
