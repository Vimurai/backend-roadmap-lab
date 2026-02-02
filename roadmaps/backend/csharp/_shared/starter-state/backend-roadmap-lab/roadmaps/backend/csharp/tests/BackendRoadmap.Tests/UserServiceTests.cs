using Xunit;
using Moq;
using System.Threading.Tasks;
using BackendRoadmap.Application.Services;
using BackendRoadmap.Contracts;
using BackendRoadmap.Domain.Entities;

namespace BackendRoadmap.Tests;

public class UserServiceTests
{
    [Fact]
    public async Task RegisterUser_ShouldCallSave()
    {
        // Arrange
        var mockRepo = new Mock<IUserRepository>();
        var service = new UserService(mockRepo.Object);
        string email = "test@example.com";

        // Act
        await service.RegisterUserAsync(email);

        // Assert
        mockRepo.Verify(r => r.SaveAsync(It.IsAny<User>()), Times.Once);
    }
}
