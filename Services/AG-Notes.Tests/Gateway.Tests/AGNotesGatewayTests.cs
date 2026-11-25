using AGNotesGateway.Controllers; 
using Xunit;

namespace AG_Notes.Tests.Gateway.Tests;

public class AgNotesGatewayTests
{
    [Fact]
    public void HelloWorldTest()
    {
        var controller = new NotesController();
        var result = controller.HelloWorld();
        Assert.Equal("Hello World", result.Value);
    }
}