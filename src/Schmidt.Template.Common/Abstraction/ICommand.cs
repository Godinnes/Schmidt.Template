using MediatR;

namespace Schmidt.Template.Common.Abstraction
{
    public interface ICommand : IRequest
    {
    }
    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }
}
