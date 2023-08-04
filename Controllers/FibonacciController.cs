using AIMOQUnitTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AIMOQUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private IFibonacciSeriesService _fibonacciSeriesService;
        public FibonacciController(IFibonacciSeriesService fibonacciSeriesService)
        {
            _fibonacciSeriesService = fibonacciSeriesService;
        }

        // GET: api/<FibonacciController>   
        [HttpGet("size")]
        public IActionResult Get(int size)
        {
            if (size < 0)
            {
                return BadRequest("Input cannot be negative");
            }
            return Ok(_fibonacciSeriesService.GenerateFibonacciSeries(size));
        }

        // generate an api to check if the input is even number
        [HttpGet("isEvenNumber")]
        public IActionResult IsEvenNumber(int input)
        {
            return Ok(_fibonacciSeriesService.IsEvenNumber(input));
        }
    }
}
 