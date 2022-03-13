using fizzbuzz.core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fizzbuzz.web.Controllers
{
    [Route("api/fizzbuzz")]
    [ApiController]
    public class FizzbuzzApiController : ControllerBase
    {
        [HttpGet, Route("getFizzbuzzResults")]
        public async Task<IActionResult> GetFizzbuzzResults()
        {
            FizzbuzzCalculator fizzy = new();
            var wordsAndNumbers = new Dictionary<int, string>
            {
                { 3, "Foo" },
                { 5, "Bar" },
                { 7, "Bazz" },
                { 11, "Banana" }
            };

            var results = fizzy.CallFizzbuzz(wordsAndNumbers);
            return Ok(results);
        }
    }
}
