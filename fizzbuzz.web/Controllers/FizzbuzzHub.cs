using fizzbuzz.core;
using Microsoft.AspNetCore.SignalR;

namespace fizzbuzz.web.Controllers
{
    public class FizzbuzzHub : Hub<IHubClient>
    {
    }

    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
