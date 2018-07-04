using System;

namespace Goldlight.Contracts
{
  public static class NullArgumentValidation
  {
    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> when <param name="value" />
    /// is null.
    /// </summary>
    /// <param name="value">The value to check for null.</param>
    /// <param name="name">The name of the argument.</param>
    /// <returns>The original value is passed in, ready for assignment.</returns>
    public static T ThrowIfNull<T>(this T value, string name)
      where T : class => value.ThrowIfNull(name, Resources.ValueMustNotBeNull);

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> when <param name="value" />
    /// is null.
    /// </summary>
    /// <param name="value">The value to check for null.</param>
    /// <param name="name">The name of the argument.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>The original value is passed in, ready for assignment.</returns>
    public static T ThrowIfNull<T>(this T value, string name, string message)
      where T : class
    {
      name.ThrowIfNullOrWhiteSpace(nameof(name));
      message.ThrowIfNullOrWhiteSpace(nameof(message));

      if (value == null)
      {
        throw new ArgumentNullException(name, message);
      }

      return value;
    }


    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> when <param name="value" />
    /// is the default for that type.
    /// </summary>
    /// <param name="value">The value to check for default.</param>
    /// <param name="name">The name of the argument.</param>
    /// <returns>The original value is passed in, ready for assignment.</returns>
    public static T ThrowIfDefault<T>(this T value, string name)
      where T : struct => value.ThrowIfDefault(name, Resources.ValueMustNotBeDefault);

    /// <summary>
    /// Throws <see cref="ArgumentNullException"/> when <param name="value" />
    /// is the default for that type.
    /// </summary>
    /// <param name="value">The value to check for default.</param>
    /// <param name="name">The name of the argument.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>The original value is passed in, ready for assignment.</returns>
    public static T ThrowIfDefault<T>(this T value, string name, string message)
      where T : struct
    {
      name.ThrowIfNullOrWhiteSpace(nameof(name));
      message.ThrowIfNullOrWhiteSpace(nameof(message));

      if (default(T).Equals(value))
      {
        throw new ArgumentException(message, name);
      }
      return value;
    }
  }
}