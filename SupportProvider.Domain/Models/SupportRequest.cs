

using SupportProvider.Domain.Enums;

namespace SupportProvider.Domain.Models;
public class SupportRequest
{
    public int RequestId { get; set; }
    public string Message { get; set; } = string.Empty;
    public SupportResponse ResponseStatus { get; set; }
}
