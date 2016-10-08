using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Api.Probe
{
    public enum ProbeProviderType
    {
        cimquery,
        eventlog,
        powershell,
        elasticsearch,
        exchange,
        lync,
        sql,
        ldap,
        tcpconnection

        //todo: add the others
    }
}
