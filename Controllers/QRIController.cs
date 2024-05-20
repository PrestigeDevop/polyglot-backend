using Microsoft.AspNetCore.Mvc;

namespace helloMVC.Controllers;

[ApiController]
[Route("[controller]")]
public class QRIController : ControllerBase
{
    private readonly ILogger<QRIController> _logger;
    public QRIController(ILogger<QRIController> logger)
    {
        _logger = logger;
    }
    [HttpGet(Name = "Get")]
    public  string Get()
    {
        return "QRI endpoint";
    }
}
