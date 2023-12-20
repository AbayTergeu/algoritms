using Tolar.BiService.Enumeration;

namespace Tolar.BiService.Domain.Abstractions.Common.Risks.Contracts;

/// <summary>
/// Risk data
/// </summary>
public class RiskData : IRiskData
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RiskData"/> class.
    /// </summary>
    /// <param name="level"></param>
    public RiskData(RiskLevel level)
    {
        Level = level;
        Value = string.Empty;
        IsManual = IsRiskManual(level);
    }

    /// <summary>
    /// Risk level
    /// </summary>
    public RiskLevel Level { get; set; }

    /// <summary>
    /// Risk value
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Is risk manual
    /// </summary>
    public bool IsManual { get; init; }

    private bool IsRiskManual(RiskLevel level) =>
         level is RiskLevel.HighManual or RiskLevel.MediumManual or RiskLevel.NoRiskManual or RiskLevel.TooHighManual;

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
        return obj is RiskData other &&
               Level == other.Level &&
               Value == other.Value &&
               IsManual == other.IsManual;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return HashCode.Combine(Level, Value, IsManual);
    }
}