using System;

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
        throw new ArgumentException();
      }

      return cast;
    }

    public static Guid ThrowIfEmpty(this Guid guid, string name) =>
      guid.ThrowIfEmpty(name, Resources.GuidMustNotBeEmpty);

    public static Guid ThrowIfEmpty(this Guid guid, string name, string message)
    {
      message.ThrowIfNullOrWhiteSpace(nameof(message));
      name.ThrowIfNullOrWhiteSpace(nameof(name));

      if (guid.Equals(Guid.Empty))
      {
        throw new ArgumentException(message, name);
      }
      return guid;
    }
  }
}