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
}
