using System;


namespace SalesWebMvc02.Models.Exceptions
{
    public class EntegrityException : ApplicationException
    {
        public EntegrityException(string message) : base(message)
        {

        }
    }
}
