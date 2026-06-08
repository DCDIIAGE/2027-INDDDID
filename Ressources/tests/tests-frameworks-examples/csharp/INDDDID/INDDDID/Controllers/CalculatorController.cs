using INDDDID.Models;
using Microsoft.AspNetCore.Mvc;
using INDDDID.Domain.Interfaces;

namespace INDDDID.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _service;

    public CalculatorController(ICalculatorService service)
    {
        _service = service;
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] AddRequest request)
    {
        var result = _service.Add(request.A, request.B);
        return Ok(new Dictionary<string, int>
        {
            ["result"] = result
        });
    }
}
