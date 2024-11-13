

using SupportProvider.Domain.Enums;
using SupportProvider.Domain.Models;

namespace SupportProvider.Business.Interfaces;
public interface IChatSupportService
{
    SupportResponse HandleChatSupport(SupportRequest request);
}
