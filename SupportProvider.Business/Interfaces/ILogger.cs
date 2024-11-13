using SupportProvider.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportProvider.Business.Interfaces;
public interface ILogger
{
    void Log(SupportResponse response, int requestId);
}
