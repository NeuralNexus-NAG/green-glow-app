using System;
using System.Collections.Generic;
using NUnit.Framework;
using UserManagementService.Business.Contracts;
using UserManagementService.Shared;
using UserManagementService.Repository.Contracts;
using UserManagementService.Business;

namespace UserManagementService.Tests
{
    [TestFixture]
    public class UserServiceTest
    {
        private IUserService _userService;
        private IUserRepository _userRepository;

        [SetUp]
        public void SetUp()
        {
            _userRepository = new FakeUserRepository();
            _userService = new UserService(_userRepository);
        }

        [Test]
        public void GetUser_WhenUserIdIsGreaterThanZero_ReturnsUser()
        {
            // Arrange
            var userId = "1";
            var expectedUser = new User
            {
                UserId = userId,
                FirstName = "John",
                LastName = "Doe",
                Email = "<EMAIL>"
            };

            _userRepository.AddUser(expectedUser);

            // Act
            var actualUser = _userService.GetUser(userId);

            // Assert
            Assert.That(actualUser, Is.EqualTo(expectedUser));
        }

        [Test]
        public void GetUser_WhenUserIdIsZeroOrNegative_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var invalidUserId = "0";

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _userService.GetUser(invalidUserId));
        }

        [Test]
        public void GetUser_WhenUserDoesNotExist_ThrowsKeyNotFoundException()
        {
            // Arrange
            var userId = "1";

            // Act and Assert
            Assert.Throws<KeyNotFoundException>(() => _userService.GetUser(userId));
        }
    }
}