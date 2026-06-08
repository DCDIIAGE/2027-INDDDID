using INDDDID.Application.Services;
using Xunit;

namespace INDDDID.Tests.DomainTests;

public class CalculatorServiceTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var service = new CalculatorService();

        var result = service.Add(2, 3);

        Assert.Equal(5, result);
    }
}
