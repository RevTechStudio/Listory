namespace Listory.Core.Models;

/// <summary>
/// チェックリスト全体を表すルートエンティティ
/// </summary>
public class CheckList
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<CheckListStructure> Structures { get; set; } = [];
}
