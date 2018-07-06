namespace Goldlight.Contracts.Exceptions
{
  /// <inheritdoc />
  /// <summary>
  /// Thrown when a type is null or cannot be cast to another type.
  /// </summary>
  public class UnableToCastException : ContractExceptionBase
  {
    public UnableToCastException(string name, string message) : base(name, message)
    {
    }
  }
}