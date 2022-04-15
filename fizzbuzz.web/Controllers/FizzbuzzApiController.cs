using fizzbuzz.core;
using fizzbuzz.core.Models;
using fizzbuzz.web.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace fizzbuzz.web.Controllers
{
    [ApiController]
    [Route("api/fizzbuzz")]
    public class FizzbuzzApiController : ControllerBase
    {
        private readonly IHubContext<FizzbuzzHub> _hub;

        public FizzbuzzApiController(IHubContext<FizzbuzzHub> hub)
        {
            _hub = hub;
        }

        [HttpPost, Route("post")]
        public IActionResult Post(FizzbuzzParametersModel parameters)
        {
            Task.Run(async () =>
            {
                if (parameters.Entries == null) return;
                if (parameters.Total == 0) return;
                if (string.IsNullOrEmpty(parameters.ConnectionId)) return;

                foreach (var output in FizzbuzzCalculator.DetermineFizzbuzz(parameters))
                {
                    await _hub.Clients.Client(parameters.ConnectionId).SendAsync("publishresult", output);
                }
            });

            return Ok();
        }
    }
}
