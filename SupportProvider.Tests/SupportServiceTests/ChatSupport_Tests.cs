

using Moq;
using SupportProvider.Business.Interfaces;
using SupportProvider.Business.Services;
using SupportProvider.Domain.Enums;
using SupportProvider.Domain.Models;

namespace SupportProvider.Tests.SupportServiceTests;
public class ChatSupport_Tests
{
    [Fact]
    public void HandleChatSupport_ShouldReturnSuccess_WhenValidSupportRequestIsSent()
    {
        // Arrange
        var loggerMock = new Mock<ILogger>();
        var chatService = new ChatSupportService(loggerMock.Object);
        var request = new SupportRequest { RequestId = 1, Message = "a" };

        // Act
        var response = chatService.HandleChatSupport(request);

        // Assert
        Assert.Equal(SupportResponse.Success, response);
        loggerMock.Verify(l => l.Log(SupportResponse.Success, request.RequestId), Times.Once);
    }

    [Fact]
    public void HandleChatSupport_ShouldReturnInvalidRequest_WhenInvalidSupportRequestIsSent()
    {
        // Arrange
        var loggerMock = new Mock<ILogger>();
        var chatService = new ChatSupportService(loggerMock.Object);
        var request = new SupportRequest { RequestId = 2, Message = "" };

        // Act
        var response = chatService.HandleChatSupport(request);

        // Assert
        Assert.Equal(SupportResponse.InvalidRequest, response);
        loggerMock.Verify(l => l.Log(SupportResponse.InvalidRequest, request.RequestId), Times.Once);
    }
}

