using Listory.Core.Models.Abstractions;

namespace Listory.Core.Models.Entities;

/// <summary>
/// チェック実行時のログ情報
/// </summary>
public class CheckListLogNote : CheckListBaseNote
{
    /// <summary>
    /// チェックリスト構成ID
    /// </summary>
    public Guid CheckListStructureId { get; set; }
    
    /// <summary>
    /// チェックリスト構成への参照
    /// </summary>
    public CheckListStructure CheckListStructure { get; set; } = null!;
}
