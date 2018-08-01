using System;
using Goldlight.Contracts.Exceptions;

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
    /// <returns>The original value that was passed in, ready for assignment.</returns>
    public static string ThrowIfNullOrWhiteSpace(this string value, string name) =>
      value.ThrowIfNullOrWhiteSpace(name, Resources.StringMustNotBeNullOrWhiteSpace);

    /// <summary>
    /// Throws <see cref="ArgumentException"/> when <param name="value" />
    /// is a null or white space string.
    /// </summary>
    /// <param name="value">The value to check for null.</param>
    /// <param name="name">The name of the argument.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>The original value that was passed in, ready for assignment.</returns>
    public static string ThrowIfNullOrWhiteSpace(this string value, string name, string message)
    {
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);
      value.CheckForNullOrWhiteSpace(name, message);

      return value;
    }

    public static string ThrowIfNullOrEmpty(this string value, string name) =>
      value.ThrowIfNullOrEmpty(name, Resources.StringMustNotBeNullOrEmpty);

    public static string ThrowIfNullOrEmpty(this string value, string name, string message)
    {
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (string.IsNullOrEmpty(value))
      {
        throw new ArgumentException(name, message);
      }

      return value;
    }

    public static string ThrowIfStartsWith(this string value, string startsWith, string name) =>
      value.ThrowIfStartsWith(startsWith, name, Resources.StringMustNotStartWith);

    public static string ThrowIfStartsWith(this string value, string startsWith, string name, string message)
    {
      startsWith.CheckForNullOrWhiteSpace(nameof(startsWith), Resources.NullOrWhiteSpaceStartsWith);
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (value.StartsWith(startsWith))
      {
        throw new InvalidTextException(name, message);
      }
      return value;
    }

    public static string ThrowIfDoesNotStartWith(this string value, string startsWith, string name) =>
      value.ThrowIfDoesNotStartWith(startsWith, name, Resources.StringMustStartWith);

    public static string ThrowIfDoesNotStartWith(this string value, string startsWith, string name, string message)
    {
      startsWith.CheckForNullOrWhiteSpace(nameof(startsWith), Resources.NullOrWhiteSpaceStartsWith);
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (!value.StartsWith(startsWith))
      {
        throw new InvalidTextException(name, message);
      }
      return value;
    }

    public static string ThrowIfDoesNotContain(this string value, string contains, string name) =>
      value.ThrowIfDoesNotContain(contains, name, Resources.StringMustContain);

    public static string ThrowIfDoesNotContain(this string value, string contains, string name, string message)
    {
      contains.CheckForNullOrWhiteSpace(nameof(contains), Resources.NullOrWhiteSpaceContains);
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (!value.Contains(contains))
      {
        throw new InvalidTextException(name, message);
      }
      return value;
    }

    public static string ThrowIfDoesNotEndWith(this string value, string contains, string name) =>
      value.ThrowIfDoesNotEndWith(contains, name, Resources.StringMustEndWith);

    public static string ThrowIfDoesNotEndWith(this string value, string contains, string name, string message)
    {
      contains.CheckForNullOrWhiteSpace(nameof(contains), Resources.NullOrWhiteSpaceEndsWith);
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (!value.EndsWith(contains))
      {
        throw new InvalidTextException(name, message);
      }
      return value;
    }
    public static string ThrowIfEndsWith(this string value, string endsWith, string name) =>
      value.ThrowIfEndsWith(endsWith, name, Resources.StringMustNotEndWith);

    public static string ThrowIfEndsWith(this string value, string endsWith, string name, string message)
    {
      endsWith.CheckForNullOrWhiteSpace(nameof(endsWith), Resources.NullOrWhiteSpaceEndsWith);
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (value.EndsWith(endsWith))
      {
        throw new InvalidTextException(name, message);
      }
      return value;
    }

    public static string ThrowIfContains(this string value, string contains, string name) =>
      value.ThrowIfContains(contains, name, Resources.StringMustNotContain);

    public static string ThrowIfContains(this string value, string contains, string name, string message)
    {
      contains.CheckForNullOrWhiteSpace(nameof(contains), Resources.NullOrWhiteSpaceContains);
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (value.Contains(contains))
      {
        throw new InvalidTextException(name, message);
      }
      return value;
    }

    internal static void CheckForNullOrWhiteSpace(this string value, string name, string message)
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        throw new ArgumentException(name, message);
      }
    }
  }
}