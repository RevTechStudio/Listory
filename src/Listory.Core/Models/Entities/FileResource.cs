namespace Listory.Core.Models.Entities;

/// <summary>
/// ファイルリソース情報
/// </summary>
public class FileResource
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
    
    /// <summary>
    /// ファイル名
    /// </summary>
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// ファイルパス
    /// </summary>
    public string FilePath { get; set; } = string.Empty;

    /// <summary>
    /// ファイルサイズ（バイト）
    /// </summary>
    public long FileSize { get; set; }

    /// <summary>
    /// MIME Type
    /// </summary>
    public string MimeType { get; set; } = string.Empty;

    /// <summary>
    /// アップロード日時（UTC）
    /// </summary>
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// アップロードユーザー識別子
    /// </summary>
    public string? UploadedBy { get; set; }

    /// <summary>
    /// SHA-256ハッシュ値（重複検出・整合性確認用）
    /// </summary>
    public string Hash { get; set; } = string.Empty;

    /// <summary>
    /// このファイルを使用しているノート添付情報
    /// </summary>
    public ICollection<NoteFileAttachment> NoteAttachments { get; set; } = [];
}
