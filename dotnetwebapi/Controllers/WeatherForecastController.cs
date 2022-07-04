using Microsoft.AspNetCore.Mvc;
using dotnetwebapi.Data;
using Microsoft.EntityFrameworkCore;

namespace dotnetwebapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly WeatherDbContext _context;
    public IEnumerable<WeatherForecast> WeatherForecasts { get; set; }

    public WeatherForecastController(WeatherDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<WeatherForecast>>> Get()
    {
        return await _context.WeatherForecasts.ToListAsync();
    }
}