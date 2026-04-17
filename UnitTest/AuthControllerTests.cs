using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using REST_DanmarksRadio.Controllers;

namespace UnitTest
{
    public class AuthControllerTests
    {
        private readonly AuthController _controller;

        public AuthControllerTests()
        {
            var settings = new Dictionary<string, string?>
            {
                { "Jwt:Key", "SuperSecretTestKey_1234567890_ABCDEF" },
                { "Jwt:Issuer", "TestIssuer" },
                { "Jwt:Audience", "TestAudience" }
            };

            IConfiguration config = new ConfigurationBuilder()
                .AddInMemoryCollection(settings)
                .Build();

            _controller = new AuthController(config);
        }

        [Fact]
        public void Login_ValidCredentials_ReturnsOk()
        {
            var login = new LoginRequest { Username = "admin", Password = "1234" };

            var result = _controller.Login(login);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Login_InvalidCredentials_ReturnsUnauthorized()
        {
            var login = new LoginRequest { Username = "wrong", Password = "wrong" };

            var result = _controller.Login(login);

            Assert.IsType<UnauthorizedObjectResult>(result);
        }
    }
}
