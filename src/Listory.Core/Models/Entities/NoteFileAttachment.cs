using Listory.Core.Models.Abstractions;

namespace Listory.Core.Models.Entities;

public class NoteFileAttachment
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// ノートID
    /// </summary>
    public Guid NoteId { get; set; }

    /// <summary>
    /// ノートへの参照
    /// </summary>
    public CheckListBaseNote Note { get; set; } = null!;

    /// <summary>
    /// ファイルリソースID
    /// </summary>
    public Guid FileResourceId { get; set; }

    /// <summary>
    /// ファイルリソースへの参照
    /// </summary>
    public FileResource FileResource { get; set; } = null!;

    /// <summary>
    /// ファイルの表示順序
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// ファイルが添付された日時
    /// </summary>
    public DateTime AttachedAt { get; set; } = DateTime.UtcNow;
}