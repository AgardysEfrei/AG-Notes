using AGNotesGateway.Controllers;
using Xunit;

namespace AGNotes.Tests.Gateway.Tests;

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