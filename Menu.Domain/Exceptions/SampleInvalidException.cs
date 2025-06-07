using Menu.Shared.Abstractions.Exceptions;

namespace Menu.Domain.Exceptions;

    public class SampleInvalidException : PublicException
    {

        public SampleInvalidException() : base("Sample ID cannot be empty.")
        {
        }
    }
