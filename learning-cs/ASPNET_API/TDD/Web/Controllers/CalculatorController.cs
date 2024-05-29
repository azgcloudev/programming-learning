using Microsoft.AspNetCore.Mvc;
using CalculatorApp;

namespace Web.Controllers;

[ApiController]
[Route("Add/{left}/{right})")]
public class CalculatorController : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public int Get(int left, int right)
    {
        var calculator = new Calculator();
        return calculator.Sum(left, right);
    }
}