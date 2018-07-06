using System;
using Goldlight.Contracts;
using Xunit;

namespace Goldlight.Contract.Tests
{
  public class StringValidationTests
  {
    [Fact]
    public void WhenStringIsNull_CallingThrowIfNullOrWhiteSpace_ThrowsArgumentException()
    {
      string testString = null;
      Assert.Throws<ArgumentException>(() => testString.ThrowIfNullOrWhiteSpace(nameof(testString)));
    }

    [Fact]
    public void WhenStringIsEmpty_CallingThrowIfNullOrWhiteSpace_ThrowsArgumentException()
    {
      string testString = string.Empty;
      Assert.Throws<ArgumentException>(() => testString.ThrowIfNullOrWhiteSpace(nameof(testString)));
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfNullOrWhiteSpace_DoesNotThrowArgumentException()
    {
      "Hello".ThrowIfNullOrWhiteSpace("Hello");
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfNullOrWhiteSpaceWithEmptyName_ThrowsArgumentException()
    {
      Assert.Throws<ArgumentException>(() => "Hello".ThrowIfNullOrWhiteSpace(string.Empty));
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfNullOrWhiteSpaceWithEmptyNameAndMessage_ThrowsArgumentException()
    {
      Assert.Throws<ArgumentException>(() => "Hello".ThrowIfNullOrWhiteSpace("Hello", string.Empty));
    }

    [Fact]
    public void WhenStringIsNull_CallingThrowIfNullOrEmpty_ThrowsArgumentException()
    {
      string testString = null;
      Assert.Throws<ArgumentException>(() => testString.ThrowIfNullOrEmpty(nameof(testString)));
    }

    [Fact]
    public void WhenStringIsEmpty_CallingThrowIfNullOrEmpty_ThrowsArgumentException()
    {
      string testString = string.Empty;
      Assert.Throws<ArgumentException>(() => testString.ThrowIfNullOrEmpty(nameof(testString)));
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfNullOrEmpty_DoesNotThrowArgumentException()
    {
      "Hello".ThrowIfNullOrEmpty("Hello");
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfNullOrEmptyWithEmptyName_ThrowsArgumentException()
    {
      Assert.Throws<ArgumentException>(() => "Hello".ThrowIfNullOrEmpty(string.Empty));
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfNullOrEmptyWithEmptyNameAndMessage_ThrowsArgumentException()
    {
      Assert.Throws<ArgumentException>(() => "Hello".ThrowIfNullOrEmpty("Hello", string.Empty));
    }

    [Fact]
    public void WhenStringIsNull_CallingThrowIfStartsWith_ThrowsArgumentException()
    {
      string testString = null;
      Assert.Throws<ArgumentException>(() => testString.ThrowIfStartsWith("Hello", nameof(testString)));
    }

    [Fact]
    public void WhenStringIsEmpty_CallingThrowIfStartsWith_ThrowsArgumentException()
    {
      string testString = string.Empty;
      Assert.Throws<ArgumentException>(() => testString.ThrowIfStartsWith("Hello", nameof(testString)));
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfStartsWith_DoesNotThrowArgumentException()
    {
      "Hello".ThrowIfStartsWith("He", "Hello");
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfStartsWithWithEmptyStartsWith_ThrowsArgumentException()
    {
      Assert.Throws<ArgumentException>(() => "Hello".ThrowIfStartsWith(string.Empty, "Hello"));
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfStartsWithWithEmptyName_ThrowsArgumentException()
    {
      Assert.Throws<ArgumentException>(() => "Hello".ThrowIfStartsWith("He", string.Empty));
    }

    [Fact]
    public void WhenStringIsNotEmpty_CallingThrowIfStartsWithWithEmptyNameAndMessage_ThrowsArgumentException()
    {
      Assert.Throws<ArgumentException>(() => "Hello".ThrowIfStartsWith("Hello", "Hello", string.Empty));
    }

  }
}
