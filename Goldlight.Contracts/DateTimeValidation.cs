using System;
using Goldlight.Contracts.Exceptions;

namespace Goldlight.Contracts
{
  public static class DateTimeValidation
  {
    public static DateTime ThrowIfEarlierThan(this DateTime dateTime, DateTime checkDateTime, string name)
      => dateTime.ThrowIfEarlierThan(checkDateTime, name, string.Format(Resources.DateCannotBeEarlierThan, dateTime, checkDateTime));

    public static DateTime ThrowIfEarlierThan(this DateTime dateTime, DateTime checkDateTime, string name, string message)
    {
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (dateTime < checkDateTime)
      {
        throw new InvalidDateException(name, message);
      }

      return dateTime;
    }

    public static DateTime ThrowIfGreaterThan(this DateTime dateTime, DateTime checkDateTime, string name)
      => dateTime.ThrowIfGreaterThan(checkDateTime, name, string.Format(Resources.DateCannotBeGreaterThan, dateTime, checkDateTime));

    public static DateTime ThrowIfGreaterThan(this DateTime dateTime, DateTime checkDateTime, string name, string message)
    {
      name.CheckForNullOrWhiteSpace(nameof(name), Resources.NullOrWhiteSpaceName);
      message.CheckForNullOrWhiteSpace(nameof(message), Resources.NullOrWhiteSpaceMessage);

      if (dateTime > checkDateTime)
      {
        throw new InvalidDateException(name, message);
      }

      return dateTime;
    }
  }
}
