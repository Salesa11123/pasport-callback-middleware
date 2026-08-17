using Microsoft.AspNetCore.Mvc;
using PaSPortCallbackMiddleware.Models;

namespace PaSPortCallbackMiddleware.Controllers;

[ApiController]
[Route("api/si-workorders-callback")]
public class PasportCallbackController : ControllerBase
{
    private readonly ILogger<PasportCallbackController> _logger;

    public PasportCallbackController(ILogger<PasportCallbackController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult ReceiveCallback([FromBody] PasportCallbackRequest request)
    {
        _logger.LogInformation(
            "PaSPort callback received. CallbackId: {CallbackId}, Code: {Code}, Message: {Message}",
            request.CallbackId,
            request.Code,
            request.Message);

        return NoContent();
    }
}
