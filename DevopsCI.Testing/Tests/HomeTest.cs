using DevopsCI.Client.Controllers;
using Xunit;

namespace DevopsCI.Testing.Tests
{
    public class HomeTest
    {
      [Fact]
      public void HomeController_Test()
      {
        var sut = new HomeController();
        var view = sut.Index();

        Assert.NotNull(view);
      }
      
    }
}