namespace Time_Line.Domain.Entities.ExceptionModels.Models
{
    public  class NotFoundException : ApplicationLayerException
    {
        protected NotFoundException(string message)
            : base("Not Found", message)
        {
        }
    }
}
