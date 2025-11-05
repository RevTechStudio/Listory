using Listory.Core.Models.Abstractions;

namespace Listory.Core.Models.Entities;

/// <summary>
/// チェックリストの構成情報
/// </summary>
public class CheckListStructure : StructureBase<CheckListStructure>
{
    /// <summary>
    /// 所属するチェックリストID
    /// </summary>
    public Guid CheckListId { get; set; }

    /// <summary>
    /// チェックリストへの参照
    /// </summary>
    public CheckList CheckList { get; set; } = null!;

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
