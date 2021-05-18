using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecast2Controller : ControllerBase
    {
        [HttpGet]
        [Route("{something}.{extension?}")]
        public string Get(string something, string extension = null)
        {
            return $"Text: {something} {extension}";
        }
    }
}