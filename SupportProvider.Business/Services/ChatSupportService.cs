using SupportProvider.Business.Interfaces;
using SupportProvider.Domain.Enums;
using SupportProvider.Domain.Models;


namespace SupportProvider.Business.Services;
public class ChatSupportService : IChatSupportService
{
    private readonly ILogger _logger;

    public ChatSupportService(ILogger logger)
    {
        _logger = logger;
    }

    public SupportResponse HandleChatSupport(SupportRequest request)
    {
        if (string.IsNullOrEmpty(request.Message))
        {
            _logger.Log(SupportResponse.InvalidRequest, request.RequestId);
            return SupportResponse.InvalidRequest;
        }

        // Behandlar en chattförfrågan och loggar svaret
        _logger.Log(SupportResponse.Success, request.RequestId);
        return SupportResponse.Success;
    }
}

