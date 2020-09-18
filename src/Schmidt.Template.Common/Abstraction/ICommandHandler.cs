using MediatR;

namespace Schmidt.Template.Common.Abstraction
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : IRequest<TResponse>
    {
    }
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Unit>
        where TCommand : IRequest<Unit>
    {
    }
}
