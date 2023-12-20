using Tolar.BiService.Domain.Abstractions.Common.Risks.Contracts;
using Tolar.BiService.Enumeration;

namespace SortByChoice;

public class B : A
{
    public string LastName { get; set; }
    public RiskData RiskData { get; set; }
    public RiskLevel RiskLevel { get; set; }
}