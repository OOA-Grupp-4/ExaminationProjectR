
using SupportProvider.Domain.Enums;
using SupportProvider.Domain.Models;

namespace SupportProvider.Business.Interfaces;
public interface IEmailSupportService
{
    SupportResponse HandleEmailSupport(SupportRequest request);
}
