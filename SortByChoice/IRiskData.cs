using Tolar.BiService.Enumeration;

namespace Tolar.BiService.Domain.Abstractions.Common.Risks;

/// <summary>
/// Risk Data
/// </summary>
public interface IRiskData
{
    /// <summary>
    /// Risk level.
    /// </summary>
    public RiskLevel Level { get; set; }

    /// /// <summary>
    /// Risk value.
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Is risk manual.
    /// </summary>
    public bool IsManual { get; init; }
}