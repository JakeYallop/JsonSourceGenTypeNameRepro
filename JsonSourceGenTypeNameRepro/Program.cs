// See https://aka.ms/new-console-template for more information
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

[JsonSerializable(typeof(IEnumerable<One.MyClass>), TypeInfoPropertyName = "IEnumerableOneMyClass")]
//[JsonSerializable(typeof(One.MyClass), TypeInfoPropertyName = "OneMyClass")]
[JsonSerializable(typeof(IEnumerable<Two.MyClass>))]
public partial class JsonContext : JsonSerializerContext
{

}

namespace One
{
    public class MyClass
    {
        public int Prop { get; set; }
    }
}

namespace Two
{
    public class MyClass
    {
        public int Prop { get; set; }
    }
}