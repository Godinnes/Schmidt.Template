using System.Threading.Tasks;

namespace Schmidt.Template.Common.Abstraction
{
    public interface IMyMediator
    {
        Task<TResult> SendAsync<TResult>(ICommand<TResult> request);
        Task SendAsync(ICommand request);
    }
}
