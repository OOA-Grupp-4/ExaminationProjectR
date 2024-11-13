using SupportProvider.Business.Interfaces;
using SupportProvider.Domain.Enums;
using SupportProvider.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportProvider.Business.Services;
public class EmailSupportService : IEmailSupportService
{
    private readonly ILogger _logger;

    public EmailSupportService(ILogger logger)
    {
        _logger = logger;
    }

    public SupportResponse HandleEmailSupport(SupportRequest request)
    {
        if (string.IsNullOrEmpty(request.Message))
        {
            _logger.Log(SupportResponse.InvalidRequest, request.RequestId);
            return SupportResponse.InvalidRequest;
        }

        // Behandlar en e-postförfrågan och loggar svaret
        _logger.Log(SupportResponse.Success, request.RequestId);
        return SupportResponse.Success;
    }
}
