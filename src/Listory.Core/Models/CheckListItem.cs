namespace Listory.Core.Models;


/// <summary>
/// チェック項目定義
/// </summary>
public class CheckListItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public CheckListNote? Note { get; set; }
}
