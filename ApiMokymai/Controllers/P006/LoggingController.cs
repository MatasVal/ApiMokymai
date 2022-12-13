using ApiMokymai.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ApiMokymai.Controllers.P006
{
    /// <summary>
    /// 6 paskiata. Demonstracija dotNet logging funkcionalumui
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoggingController : ControllerBase
    {
        private readonly ILogger<LoggingController> _logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Demonstruojamas bazinis visu loginimo lygiu funkcionalumas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetLoggingResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
