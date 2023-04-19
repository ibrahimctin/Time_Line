namespace Time_Line.Domain.Application.Abstraction.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
