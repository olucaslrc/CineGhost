using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers;

[ApiController]
[Route("api/v1/services/[controller]")]
public class ManagerController : ControllerBase
{
    private readonly ILogger<ManagerController> _logger;

    public ManagerController(ILogger<ManagerController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Get()
    {
        return StatusCode(200);
    }
}
