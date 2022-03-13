using fizzbuzz.core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fizzbuzz.web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FizzbuzzApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string[]> Get()
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
            yield return results;
        }
    }
}
