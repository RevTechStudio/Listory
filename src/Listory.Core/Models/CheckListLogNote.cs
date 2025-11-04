namespace Listory.Core.Models;


/// <summary>
/// チェック実行時のログ情報
/// </summary>
public class CheckListLogNote : CheckListBaseNote
{
    public Guid CheckListStructureId { get; set; }
    public CheckListStructure CheckListStructure { get; set; } = null!;
}
