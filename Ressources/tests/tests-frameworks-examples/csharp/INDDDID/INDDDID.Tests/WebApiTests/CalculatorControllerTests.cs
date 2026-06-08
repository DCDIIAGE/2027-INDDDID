using INDDDID.Application.Services;
using INDDDID.Controllers;
using INDDDID.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace INDDDID.Tests.WebApiTests;

public class CalculatorControllerTests
{
    [Fact]
    public void Add_ShouldReturnOkWithCorrectResult()
    {
        var controller = new CalculatorController(new CalculatorService());

        var request = new AddRequest { A = 10, B = 5 };

        var response = controller.Add(request) as OkObjectResult;

        Assert.NotNull(response);
        Assert.Equal(200, response.StatusCode);

        var dict = Assert.IsType<Dictionary<string, int>>(response.Value);
        Assert.Equal(15, dict["result"]);
    }
}
