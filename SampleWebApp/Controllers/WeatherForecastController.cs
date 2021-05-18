using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("{something}.{extension=foo}")]
        public string Get(string something, string extension)
        {
            return $"Text: {something} {extension}";
        }
    }
}
