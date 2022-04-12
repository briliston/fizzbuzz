using fizzbuzz.core;
using Microsoft.AspNetCore.Mvc;

namespace fizzbuzz.web.Controllers
{
    [Route("api/fizzbuzz")]
    [ApiController]
    public class FizzbuzzApiController : ControllerBase
    {
        private readonly FizzbuzzService _fizzbuzzService;

        public FizzbuzzApiController(FizzbuzzService fizzbuzzService)
        {
            _fizzbuzzService = fizzbuzzService;
        }

        [HttpGet, Route("getFizzbuzzResults")]
        public void GetFizzbuzzResults(Dictionary<int, string> wordsWithNumbers)
        {
            _fizzbuzzService.DetermineFizzbuzzValues(wordsWithNumbers);
            //might call to a hub for signal r that actually calls the service? ask Johann
        }
    }
}
