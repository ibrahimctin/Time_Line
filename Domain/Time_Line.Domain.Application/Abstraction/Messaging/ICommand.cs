namespace Time_Line.Domain.Application.Abstraction.Messaging
{
    public interface ICommand<out TResponse> : MediatR.IRequest<TResponse>
    {
    }
}
