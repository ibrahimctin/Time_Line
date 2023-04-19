namespace Time_Line.Domain.Entities.ExceptionModels
{
    public class TokenException : Exception
    {
        public TokenException(string exceptionMessage) : base(exceptionMessage) { }
    }
}