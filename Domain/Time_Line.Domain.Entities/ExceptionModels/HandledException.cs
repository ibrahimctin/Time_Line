namespace Time_Line.Domain.Enitities.ExceptionModels
{
    public class HandledException : Exception
    {
        public HandledException(string exceptionMessage) : base(exceptionMessage) { }
    }
}