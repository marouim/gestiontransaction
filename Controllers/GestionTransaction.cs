using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//test
namespace gestion_transaction.Controllers
{
  [ApiController]
  [Route("/")]
  public class GestionTransactionController : ControllerBase
  {

    private readonly ILogger<GestionTransactionController> _logger;

    public GestionTransactionController(ILogger<GestionTransactionController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Transaction management v2.2");
    }

    [HttpPost]
    public async Task<IActionResult> Post()
    {
    
        using (var reader = new StreamReader(Request.Body))
        {
            var transaction = await reader.ReadToEndAsync();

            _logger.LogInformation("NOUVELLE TRANSACTION: " + transaction);
            _logger.LogInformation("DEBUT GESTION TRANSACTION: " + transaction);

            Thread.Sleep(8000);

            _logger.LogInformation("SUCCESS GESTION TRANSACTION: " + transaction);

        }

        return Ok();
    }

    [HttpGet]
    [Route("/healtz")]
    public IActionResult GetHealtz()
    {
      return Ok();
    }
  }
}
