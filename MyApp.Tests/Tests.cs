using MyApp.Core;

namespace MyApp.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        _ = new Thingamajig();
        _ = new MyException();
    }
}
