namespace Listory.Core.Models;


/// <summary>
/// Note/Record共通の基本構造
/// </summary>
public abstract class CheckListBaseNote
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public ICollection<FileResource> Files { get; set; } = [];
}
