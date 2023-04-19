namespace Time_Line.Domain.Entities.ExceptionModels.Models
{
    public abstract class ApplicationLayerException:Exception
    {
        protected ApplicationLayerException(string title, string message)
            : base(message) =>
            Title = title;

        public string Title { get; }
    }
}
