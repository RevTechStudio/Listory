namespace Listory.Core.Models;


/// <summary>
/// チェック実行時の記録情報
/// </summary>
public class CheckListRecord : CheckListBaseNote
{
    public Guid CheckListStructureId { get; set; }
    public CheckListStructure CheckListStructure { get; set; } = null!;
}
