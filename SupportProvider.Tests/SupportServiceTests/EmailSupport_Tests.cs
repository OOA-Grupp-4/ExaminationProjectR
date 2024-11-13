using Moq;
using SupportProvider.Business.Interfaces;
using SupportProvider.Business.Services;
using SupportProvider.Domain.Enums;
using SupportProvider.Domain.Models;


namespace SupportProvider.Tests.SupportServiceTests;
public class EmailSupport_Tests
{
    [Fact]
    public void HandleEmailSupport_ShouldReturnSuccess_WhenValidSupportRequestIsSent()
    {
        // Arrange
        var loggerMock = new Mock<ILogger>();
        var emailService = new EmailSupportService(loggerMock.Object);
        var request = new SupportRequest { RequestId = 1, Message = "a" };

        // Act
        var response = emailService.HandleEmailSupport(request);

        // Assert
        Assert.Equal(SupportResponse.Success, response);
        loggerMock.Verify(l => l.Log(SupportResponse.Success, request.RequestId), Times.Once);
    }

    [Fact]
    public void HandleEmailSupport_ShouldReturnInvalidRequest_WhenInvalidSupportRequestIsSent()
    {
        // Arrange
        var loggerMock = new Mock<ILogger>();
        var emailService = new EmailSupportService(loggerMock.Object);
        var request = new SupportRequest { RequestId = 2, Message = "" };

        // Act
        var response = emailService.HandleEmailSupport(request);

        // Assert
        Assert.Equal(SupportResponse.InvalidRequest, response);
        loggerMock.Verify(l => l.Log(SupportResponse.InvalidRequest, request.RequestId), Times.Once);
    }
}
