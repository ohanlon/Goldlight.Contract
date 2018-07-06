namespace Goldlight.Contracts.Exceptions
{
  /// <inheritdoc />
  /// <summary>
  /// Exception raised when a collection is empty.
  /// </summary>
  public class EmptyCollectionException : ContractExceptionBase
  {
    public EmptyCollectionException(string name, string message) : base(name, message)
    {
    }
  }
}