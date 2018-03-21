using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContosoUniversityCore.Features.Ping
{
    public class PingController : Controller
    {
        private readonly IMediator _mediator;

        public PingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(Index.Query query)
        {
            var model = await _mediator.Send(query);

            return View(model);
        }
    }
}