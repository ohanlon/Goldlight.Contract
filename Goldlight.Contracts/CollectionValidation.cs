using System.Collections.Generic;
using System.Linq;
using Goldlight.Contracts.Exceptions;

namespace Goldlight.Contracts
{
  public static class CollectionValidation
  {
    /// <summary>
    /// Throws <see cref="EmptyCollectionException"/> if the collection is empty.
    /// </summary>
    /// <typeparam name="T">The type of item in the collection.</typeparam>
    /// <param name="collection">The collection to check.</param>
    /// <param name="name">The name of the collection.</param>
    /// <returns>Returns the collection if not empty.</returns>
    public static IEnumerable<T> ThrowIfNullOrEmpty<T>(this IEnumerable<T> collection, string name) 
      => collection.ThrowIfNullOrEmpty(name, Resources.CollectionMustNotBeEmpty);

    /// <summary>
    /// Throws <see cref="EmptyCollectionException"/> if the collection is empty.
    /// </summary>
    /// <typeparam name="T">The type of item in the collection.</typeparam>
    /// <param name="collection">The collection to check.</param>
    /// <param name="name">The name of the collection.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>Returns the collection if not empty.</returns>
    public static IEnumerable<T> ThrowIfNullOrEmpty<T>(this IEnumerable<T> collection, string name, string message)
    {
      collection.ThrowIfNull(nameof(collection));
      name.ThrowIfNullOrWhiteSpace(nameof(name));
      message.ThrowIfNullOrWhiteSpace(nameof(message));

      if (!collection.Any())
      {
        throw new EmptyCollectionException(name, message);
      }

      return collection;
    }

    /// <summary>
    /// Throws <see cref="EmptyCollectionException"/> if the array is empty.
    /// </summary>
    /// <typeparam name="T">The type of item in the collection.</typeparam>
    /// <param name="array">The collection to check.</param>
    /// <param name="name">The name of the collection.</param>
    /// <returns>Returns the collection if not empty.</returns>
    public static T[] ThrowIfNullOrEmpty<T>(this T[] array, string name) =>
      array.ThrowIfNullOrEmpty(name, Resources.ArrayMustNotBeEmpty);

    /// <summary>
    /// Throws <see cref="EmptyCollectionException"/> if the array is empty.
    /// </summary>
    /// <typeparam name="T">The type of item in the collection.</typeparam>
    /// <param name="array">The collection to check.</param>
    /// <param name="name">The name of the collection.</param>
    /// <param name="message">The custom message to be used in the exception.</param>
    /// <returns>Returns the collection if not empty.</returns>
    public static T[] ThrowIfNullOrEmpty<T>(this T[] array, string name, string message)
    {
      array.ThrowIfNull(nameof(array));
      name.ThrowIfNullOrWhiteSpace(nameof(name));
      message.ThrowIfNullOrWhiteSpace(nameof(message));

      if (array.Length == 0)
      {
        throw new EmptyCollectionException(name, message);
      }
      return array;
    }
  }
}