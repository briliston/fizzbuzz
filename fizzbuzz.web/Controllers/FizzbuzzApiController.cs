using fizzbuzz.core;
using fizzbuzz.web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace fizzbuzz.web.Controllers
{
    [ApiController]
    [Route("api/fizzbuzz")]
    public class FizzbuzzApiController : ControllerBase
    {
        private readonly IHubContext<FizzbuzzHub, IHubClient> _hub;
        private readonly IFizzbuzzService _fizzbuzzService;

        public FizzbuzzApiController(IHubContext<FizzbuzzHub, IHubClient> hub, IFizzbuzzService fizzbuzzService)
        {
            _hub = hub;
            _fizzbuzzService = fizzbuzzService;
        }

        [HttpGet, Route("fizzbuzzResults")]
        public async Task<IActionResult> GetFizzbuzzResults(Dictionary<string, int> pairs)
        {
            _fizzbuzzService.SendFizzbuzzAsItIsDetermined(pairs);
            await _hub.Clients.All.BroadcastMessage();
            return Ok();
        }
    }
}
