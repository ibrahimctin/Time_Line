namespace Time_Line.Domain.Entities.ExceptionModels.Models
{
    public abstract class BadRequestException : ApplicationLayerException
    {
        protected BadRequestException(string message)
            : base("Bad Request", message)
        {
        }
    }
}
