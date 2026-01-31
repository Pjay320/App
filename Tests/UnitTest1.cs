using Xunit;
using Shared;
public class ResourceTests
{
    [Fact]
    public void CreateResource_ShouldSetStatus()
    {
        var res = new Resource { Name = "Test" };
        Assert.Equal("Dostępny", res.Status); 
    }
}