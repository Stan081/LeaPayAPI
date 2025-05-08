//using Lea.Data.Models;
//using Lea.Repository.Interfaces;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace LeaAPI.Test.Services
//{
//    public class UserServiceTest
//    {
//        [Fact]
//        public async Task RegisterUserAsync_ShouldCreateUser_WhenValidInput()
//        {
//            // Arrange
//            var userRepositoryMock = new Mock<IUserRepository>();
//            var userService = new UserService(userRepositoryMock.Object);
//            var createUserDto = new CreateUserDto { Email = "test@example.com", Name = "Test User", PhoneNumber = "1234567890" };

//            // Act
//            var result = await userService.RegisterUserAsync(createUserDto);

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal(createUserDto.Email, result.Email);
//        }

//        [Fact]
//        public async Task LoginUserAsync_ShouldReturnUser_WhenValidEmail()
//        {
//            // Arrange
//            var userRepositoryMock = new Mock<IUserRepository>();
//            var user = new User { Email = "test@example.com", Name = "Test User" };
//            userRepositoryMock.Setup(repo => repo.GetUserByEmailAsync(It.IsAny<string>())).ReturnsAsync(user);
//            var userService = new UserService(userRepositoryMock.Object);

//            // Act
//            var result = await userService.LoginUserAsync(new LoginUserDto { Email = "test@example.com" });

//            // Assert
//            Assert.NotNull(result);
//            Assert.Equal(user.Email, result.Email);
//        }

//        [Fact]
//        public async Task GetUserByEmailAsync_ShouldThrowException_WhenUserNotFound()
//        {
//            // Arrange
//            var userRepositoryMock = new Mock<IUserRepository>();
//            userRepositoryMock.Setup(repo => repo.GetUserByEmailAsync(It.IsAny<string>())).ReturnsAsync((User)null);
//            var userService = new UserService(userRepositoryMock.Object);

//            // Act & Assert
//            await Assert.ThrowsAsync<Exception>(() => userService.GetUserByEmailAsync("nonexistent@example.com"));
//        }

//    }
//}
