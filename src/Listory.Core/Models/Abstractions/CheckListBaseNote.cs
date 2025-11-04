using Listory.Core.Models.Entities;

namespace Listory.Core.Models.Abstractions;

/// <summary>
/// ReferenceNote / LogNote共通の基本構造
/// </summary>
public abstract class CheckListBaseNote
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
    
    /// <summary>
    /// タイトル
    /// </summary>
    public string Title { get; set; } = string.Empty;
    
    /// <summary>
    /// コンテンツ
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 添付ファイルリスト
    /// </summary>
    public ICollection<NoteFileAttachment> FileAttachments { get; set; } = [];
    
}
