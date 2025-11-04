using Listory.Core.Models.Abstractions;
using Listory.Core.Models.Enums;

namespace Listory.Core.Models.Entities;

public class CheckListTemplate : CheckListBase
{
    /// <summary>
    /// テンプレートの一意識別子
    /// （全バージョンで共通）
    /// </summary>
    public Guid TemplateId { get; set; } = Guid.NewGuid();

    /// <summary>
    /// テンプレートのバージョン
    /// </summary>
    public int Version { get; set; } = 1;

    /// <summary>
    /// テンプレートのステータス
    /// </summary>
    public CheckListTemplateStatus Status { get; set; } = CheckListTemplateStatus.Active;
}
