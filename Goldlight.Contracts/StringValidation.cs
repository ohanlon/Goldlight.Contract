using System;

namespace Goldlight.Contracts
{
  /// <summary>
  /// Validators for strings.
  /// </summary>
  public static class StringValidation
  {
    /// <summary>
    /// Throws <see cref="ArgumentException"/> when <param name="value" />
    /// is a null or white space string.
    /// </summary>
    /// <param name="value">The value to check for null.</param>
    /// <param name="name">The name of the argument.</param>
    /// <returns>The original value is passed in, ready for assignment.</returns>
    public static string ThrowIfNullOrWhiteSpace(this string value, string name) =>
      value.ThrowIfNullOrWhiteSpace(name, Resources.StringMustNotBeNullOrWhiteSpace);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> when <param name="value" />
    /// is a null or white space string.
    /// </summary>
    /// <param name="value">The value to check for null.</param>
    /// <param name="name">The name of the argument.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>The original value is passed in, ready for assignment.</returns>
    public static string ThrowIfNullOrWhiteSpace(this string value, string name, string message)
    {
      name.ThrowIfNullOrWhiteSpace(nameof(name));
      message.ThrowIfNullOrWhiteSpace(nameof(message));

      if (string.IsNullOrWhiteSpace(value))
      {
        throw new ArgumentException(name, message);
      }

      return value;
    }

    public static string ThrowIfNullOrEmpty(this string value, string name) =>
      value.ThrowIfNullOrEmpty(name, Resources.StringMustNotBeNullOrEmpty);

    public static string ThrowIfNullOrEmpty(this string value, string name, string message)
    {
      name.ThrowIfNullOrWhiteSpace(nameof(name));
      message.ThrowIfNullOrWhiteSpace(nameof(message));

      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException(name, message);
      }

      return value;
    }
  }
}