using WebApplication1.Models;
using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApisConPuntoNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AutomovilController : ControllerBase
{
    IAutomovilService automovilService;

    public AutomovilController(IAutomovilService service)
    {
        automovilService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(automovilService.Get());
    }


    [HttpPost]
    public IActionResult Post([FromBody] Automovil automovil)
    {
        automovilService.Save(automovil);
        return Ok();
    }


}