namespace Time_Line.Domain.Entities.ExceptionModels
{
    public class HandledException : Exception
    {
        public HandledException(string exceptionMessage) : base(exceptionMessage) { }
    }
}