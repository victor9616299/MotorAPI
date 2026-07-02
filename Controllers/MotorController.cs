using Microsoft.AspNetCore.Mvc;
using DataAccess.Repositorios.Contratos;
using Dominio;

namespace procafeiro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MotorController : ControllerBase
{
    private readonly IMotorRepositorio _motorRepositorio;

    public MotorController(IMotorRepositorio motorRepositorio)
    {
        _motorRepositorio = motorRepositorio;
    }

    [HttpGet]
    public IActionResult ListarMotores()
    {
        var motores = _motorRepositorio.ListarTodos();

        if (!motores.Any())
            return NoContent();

        return Ok(motores);
    }

    [HttpGet("{motorID}")]
    public IActionResult Get(int motorID)
    {
        var motor = _motorRepositorio.ObterPorId(motorID);

        if (motor == null)
            return NotFound();

        return Ok(motor);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Motor motor)
    {
        _motorRepositorio.AdicionarMotor(motor);

        return CreatedAtAction(
            nameof(Get),
            new { motorID = motor.IdMotor },
            motor
        );
    }
}