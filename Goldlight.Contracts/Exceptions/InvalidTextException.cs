namespace Goldlight.Contracts.Exceptions
{
  public class InvalidTextException : ContractExceptionBase
  {
    public InvalidTextException(string name, string message) : base(name, message)
    {
    }
  }
}
