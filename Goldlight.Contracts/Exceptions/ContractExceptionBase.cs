using System;

namespace Goldlight.Contracts.Exceptions
{
  /// <inheritdoc />
  /// <summary>
  /// Base class for the custom exceptions raised.
  /// </summary>
  public abstract class ContractExceptionBase : Exception
  {
    protected ContractExceptionBase(string name, string message) : base(message)
    {
      Name = name.ThrowIfNullOrWhiteSpace(nameof(name));
    }

    public string Name { get; }
  }
}