using System.Threading.Tasks;
using App.Models;
using App.Repositories;
using App.Services;
using Moq;
using Xunit;

namespace App.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public async Task create_async_should_invoke_add_async_on_repository()
        {
            //Arrange
            var userRepositoryMock = new Mock<IUserRepository>();
            var userService = new UserService(userRepositoryMock.Object);

            //Act
            await userService.CreateAsync("user@test.com", "secret");

            //Assert
            userRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
        }    

        [Fact]
        public async Task when_calling_get_async_and_user_exists_it_should_invoke_user_repository_get_async()
        {
            //Arrange
            var userRepositoryMock = new Mock<IUserRepository>();
            var userService = new UserService(userRepositoryMock.Object);
            var email = "user@test.com";
            var user = new User(email, "secret");
            userRepositoryMock.Setup(x => x.GetAsync(It.IsAny<string>()))
                              .ReturnsAsync(user);

            //Act
            await userService.GetAsync(email);

            //Assert
            userRepositoryMock.Verify(x => x.GetAsync(It.IsAny<string>()), Times.Once());
        }
    }
}