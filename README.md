# Goldlight.Contract
## .NET contract validation.
Over the years, I have collected together many handy little bits of argument validation for verifying the input contracts to methods. This library will bring them together along with ones that just naturally seem to go together.

## Sample usage
```csharp
public class Example
{
  public string Name;
}

public class ExampleTest
{
  public void TestExample(Example example, string name)
  {
  	example.ThrowIfNull(nameof(example));
	name.ThrowIfNullOrWhiteSpace(nameof(name), "Cannot add an empty name to the Name property");
	example.Name = name;
  }
}
```