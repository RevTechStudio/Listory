using Listory.Core.Models.Abstractions;
using Listory.Core.Models.Enums;

namespace Listory.Core.Models.Entities;

/// <summary>
/// チェックリスト全体を表すルートエンティティ
/// </summary>
public class CheckList : CheckListBase
{
    /// <summary>
    /// テンプレートの一意識別子
    /// </summary>
    public Guid TemplateId { get; set; } = Guid.Empty;
    
    /// <summary>
    /// テンプレートのバージョン
    /// </summary>
    public int TemplateVersion { get; set; } = 0;
    
    /// <summary>
    /// チェックリストの状態
    /// </summary>
    public CheckListStatus Status { get; set; } = CheckListStatus.Active;

    /// <summary>
    /// チェックリストの構成要素（子要素、項目など）
    /// </summary>
    public ICollection<CheckListStructure> Structures { get; set; } = [];
}
