using System;
using System.Collections.Generic;
using Goldlight.Contracts;
using Goldlight.Contracts.Exceptions;
using Xunit;

namespace Goldlight.Contract.Tests
{
  public class CollectionValidationTests
  {
    [Fact]
    public void WhenCollection_IsNull_ThrowArgumentNullException()
    {
      List<string> list = null;
      Assert.Throws<ArgumentNullException>(() => list.ThrowIfNullOrEmpty(nameof(list)));
    }

    [Fact]
    public void WhenCollection_IsEmpty_ThrowEmptyCollectionException()
    {
      // ReSharper disable once CollectionNeverUpdated.Local
      List<string> list = new List<string>();
      Assert.Throws<EmptyCollectionException>(() => list.ThrowIfNullOrEmpty(nameof(list)));
    }

    [Fact]
    public void WhenCollection_HasNoNameElement_ThrowArgumentException()
    {
      // ReSharper disable once CollectionNeverUpdated.Local
      List<string> list = new List<string>();
      Assert.Throws<ArgumentException>(() => list.ThrowIfNullOrEmpty(string.Empty));
    }

    [Fact]
    public void WhenCollection_HasNoMessageElement_ThrowArgumentException()
    {
      // ReSharper disable once CollectionNeverUpdated.Local
      List<string> list = new List<string>();
      Assert.Throws<ArgumentException>(() => list.ThrowIfNullOrEmpty(nameof(list), string.Empty));
    }

    [Fact]
    public void WhenCollection_IsNotEmpty_ThrowArgumentNullException()
    {
      List<string> list = new List<string> {"Hello"};
      list.ThrowIfNullOrEmpty(nameof(list));
    }

    [Fact]
    public void WhenArray_IsNull_ThrowArgumentNullException()
    {
      string[] list = null;
      Assert.Throws<ArgumentNullException>(() => list.ThrowIfNullOrEmpty(nameof(list)));
    }

    [Fact]
    public void WhenArray_IsEmpty_ThrowEmptyCollectionException()
    {
      string[] list = new string[]{};
      Assert.Throws<EmptyCollectionException>(() => list.ThrowIfNullOrEmpty(nameof(list)));
    }

    [Fact]
    public void WhenArray_IsNotEmpty_ThrowArgumentNullException()
    {
      string[] list = { "Hello" };
      list.ThrowIfNullOrEmpty(nameof(list));
    }


    [Fact]
    public void WhenArray_HasNoNameElement_ThrowArgumentException()
    {
      string[] list = { "Hello" };
      Assert.Throws<ArgumentException>(() => list.ThrowIfNullOrEmpty(string.Empty));
    }

    [Fact]
    public void WhenArray_HasNoMessageElement_ThrowArgumentException()
    {
      string[] list = { "Hello" };
      Assert.Throws<ArgumentException>(() => list.ThrowIfNullOrEmpty(nameof(list), string.Empty));
    }
  }
}
