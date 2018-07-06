using System;
using UnableToCastException = Goldlight.Contracts.Exceptions.UnableToCastException;

namespace Goldlight.Contracts
{
  public static class GeneralValidation
  {
    public static TCastType ThrowIfNullOrCannotCast<T, TCastType>(this T source, string name)
      where T : class
      where TCastType : class => source.ThrowIfNullOrCannotCast<T, TCastType>(name, Resources.UnableToCast);

    public static TCastType ThrowIfNullOrCannotCast<T, TCastType>(this T source, string name, string message)
      where T : class
      where TCastType : class
    {
      source.ThrowIfNull(nameof(source));
      message.ThrowIfNullOrWhiteSpace(nameof(message));
      name.ThrowIfNullOrWhiteSpace(nameof(name));

      if (!(source is TCastType cast))
      {
        throw new UnableToCastException(name, message);
      }

      return cast;
    }

    /// <summary>
    /// Throws <see cref="ArgumentException"/> when <param name="guid" />
    /// is not empty.
    /// </summary>
    /// <param name="guid">The Guid to check.</param>
    /// <param name="name">The name of the argument.</param>
    /// <returns>The original value that was passed in, ready for assignment.</returns>
    public static Guid ThrowIfNotEmpty(this Guid guid, string name) 
      => guid.ThrowIfNotEmpty(name, Resources.GuidMustNotBeEmpty);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> when <param name="guid" />
    /// is not empty.
    /// </summary>
    /// <param name="guid">The Guid to check.</param>
    /// <param name="name">The name of the argument.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>The original value that was passed in, ready for assignment.</returns>
    public static Guid ThrowIfNotEmpty(this Guid guid, string name, string message)
    {
      message.ThrowIfNullOrWhiteSpace(nameof(message));
      name.ThrowIfNullOrWhiteSpace(nameof(name));

      if (!guid.Equals(Guid.Empty))
      {
        throw new ArgumentException(message, name);
      }

      return guid;
    }


    /// <summary>
    /// Throws <see cref="ArgumentException"/> when <param name="guid" />
    /// is empty.
    /// </summary>
    /// <param name="guid">The Guid to check.</param>
    /// <param name="name">The name of the argument.</param>
    /// <returns>The original value that was passed in, ready for assignment.</returns>
    public static Guid ThrowIfEmpty(this Guid guid, string name) =>
      guid.ThrowIfEmpty(name, Resources.GuidMustNotBeEmpty);


    /// <summary>
    /// Throws <see cref="ArgumentException"/> when <param name="guid" />
    /// is empty.
    /// </summary>
    /// <param name="guid">The Guid to check.</param>
    /// <param name="name">The name of the argument.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>The original value that was passed in, ready for assignment.</returns>
    public static Guid ThrowIfEmpty(this Guid guid, string name, string message)
    {
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (guid.Equals(Guid.Empty))
      {
        throw new ArgumentException(message, name);
      }
      return guid;
    }
  }
}