using MediatR;
using System.Threading.Tasks;

namespace ContosoUniversityCore.Features.Ping
{
    public class Pong
    {
        public class Query : IRequest<Result>
        {
        }

        public class Result
        {
        }

        public class Handler : AsyncRequestHandler<Query, Result>
        {
            private readonly IMediator _mediator;

            public Handler(IMediator mediator)
            {
                _mediator = mediator;
            }

            protected override async Task<Result> HandleCore(Query message)
            {
                return new Result();
            }
        }
    }
}