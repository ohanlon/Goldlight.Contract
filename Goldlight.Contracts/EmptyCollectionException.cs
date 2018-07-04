using System;

namespace Goldlight.Contracts
{
  /// <inheritdoc />
  /// <summary>
  /// Exception raised when a collection is empty.
  /// </summary>
  public class EmptyCollectionException : Exception
  {
    public EmptyCollectionException(string name)
    {
      Name = name.ThrowIfNullOrWhiteSpace(nameof(name));
    }

    public EmptyCollectionException(string name, string message) : base(message)
    {
      Name = name.ThrowIfNullOrWhiteSpace(nameof(name));
    }

    public string Name;
  }
}