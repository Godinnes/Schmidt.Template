using MediatR;
using Schmidt.Template.Common.Abstraction;
using System.Threading.Tasks;

namespace Schmidt.Template.Common.Implementations
{
    public class MyMediator : IMyMediator
    {
        private readonly IMediator _mediator;
        public MyMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<TResult> SendAsync<TResult>(ICommand<TResult> request)
        {
            return await _mediator.Send(request, default);
        }

        public Task SendAsync(ICommand request)
        {
            return _mediator.Send(request);
        }
    }
}
