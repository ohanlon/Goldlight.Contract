using System;

namespace Goldlight.Contracts.Exceptions
{
  public class InvalidDateException : ContractExceptionBase
  {
    public InvalidDateException(string name, string message) : base(name, message)
    {
    }
  }
}
