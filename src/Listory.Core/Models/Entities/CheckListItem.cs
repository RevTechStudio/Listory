namespace Listory.Core.Models.Entities;

/// <summary>
/// チェック項目定義
/// </summary>
public class CheckListItem
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// 項目名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 項目の説明
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// リファレンスノート
    /// </summary>
    public CheckListReferenceNote? ReferenceNote { get; set; }
}
