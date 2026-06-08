using INDDDID.Application.Services;
using INDDDID.Controllers;
using INDDDID.Models;
using Xunit;

namespace MyDemoProject.Tests.E2ETests;

public class CalculatorE2ETests
{
    [Fact]
    public void UserScenario_AddTwoNumbers()
    {
        var service = new CalculatorService();
        var controller = new CalculatorController(service);

        var request = new AddRequest { A = 7, B = 8 };

        var response = controller.Add(request) as Microsoft.AspNetCore.Mvc.OkObjectResult;

        var dict = Assert.IsType<Dictionary<string, int>>(response.Value);
        Assert.Equal(15, dict["result"]);
    }
}
