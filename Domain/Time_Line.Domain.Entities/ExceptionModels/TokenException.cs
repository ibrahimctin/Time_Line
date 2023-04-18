namespace Time_Line.Domain.Enitities.ExceptionModels
{
    public class TokenException : Exception
    {
        public TokenException(string exceptionMessage) : base(exceptionMessage) { }
    }
}