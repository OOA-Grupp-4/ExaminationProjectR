using SupportProvider.Business.Interfaces;
using SupportProvider.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportProvider.Business.Services;
public class Logger : ILogger
{
    //Här är det tänkt att man ska skriva logga informationen till en databas
    public void Log(SupportResponse response, int requestId)
    {
        throw new NotImplementedException();
    }
}
