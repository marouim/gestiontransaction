using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
      return Ok("Gestion Transaction v0.1.3");
    }

    [HttpPost]
    public String Post(String transaction)
    {

      _logger.LogInformation("NOUVELLE TRANSACTION: " + transaction);
      _logger.LogInformation("DEBUT GESTION TRANSACTION: " + transaction);

      Thread.Sleep(8000);

      _logger.LogInformation("SUCCESS GESTION TRANSACTION: " + transaction);

      return transaction;
    }

    [HttpGet]
    [Route("/healtz")]
    public IActionResult GetHealtz()
    {
      return Ok();
    }
  }
}
