﻿namespace Time_Line.Domain.Entities.ExceptionModels
{
    public class HandledExceptionList : Exception
    {
        public ICollection<string> ExceptionMessages { get; set; }
        public HandledExceptionList(ICollection<string> exceptionMessages)
        {
            ExceptionMessages = exceptionMessages;
        }
    }
}