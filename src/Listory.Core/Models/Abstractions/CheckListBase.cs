namespace Listory.Core.Models.Abstractions;

/// <summary>
/// チェックリストの基底となる抽象クラス
/// </summary>
public abstract class CheckListBase
{
    /// <summary>
    /// 一意識別子
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// チェックリスト名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// チェックリストの説明
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 作成日
    /// </summary>
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// 作成者
    /// </summary>
    public string? CreatedBy { get; set; }
}