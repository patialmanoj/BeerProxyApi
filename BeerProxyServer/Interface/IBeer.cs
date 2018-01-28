using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProxyServer.Interface
{
    public interface IBeer
    {
        string Get();
        string Get(string id);
    }
}
