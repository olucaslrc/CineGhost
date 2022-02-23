using Microsoft.AspNetCore.Mvc;

namespace CineGhost.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CineGhostController : ControllerBase
{
    private readonly ILogger<CineGhostController> _logger;

    public CineGhostController(ILogger<CineGhostController> logger)
    {
        _logger = logger;
    }

    public ILogger<CineGhostController> Logger => _logger;

    [HttpGet("")]
    public IActionResult Get()
    {
        return StatusCode(200);
    }
}