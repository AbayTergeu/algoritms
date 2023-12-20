namespace Tolar.BiService.Enumeration;

/// <summary>
/// Level of risk.
/// </summary>
public enum RiskLevel
{
    /// <summary>
    /// Default.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// No risk.
    /// </summary>
    NoRisk = 1,

    /// <summary>
    /// No risk manual.
    /// </summary>
    NoRiskManual = 2,

    /// <summary>
    /// Medium risk.
    /// </summary>
    Medium = 3,

    /// <summary>
    /// Medium risk manual.
    /// </summary>
    MediumManual = 4,

    /// <summary>
    /// High risk.
    /// </summary>
    High = 5,

    /// <summary>
    /// High risk manual.
    /// </summary>
    HighManual = 6,

    /// <summary>
    /// Too high risk.
    /// </summary>
    TooHigh = 7,

    /// <summary>
    /// Too high risk manual.
    /// </summary>
    TooHighManual = 8,
}