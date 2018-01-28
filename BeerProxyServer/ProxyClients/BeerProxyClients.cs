using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProxyServer.Interface;
using BeerProxyServer.Controller;
using System.Configuration;
using BeerProxyServer.DTO;
using Newtonsoft.Json;

namespace BeerProxyServer.ProxyClients
{
    public class BeerProxyClient : IBeer
    {
       
        private string proxyController = "";
        
        public string Get()
        {
            string serializeResponseInfo = "";
            try
            {
               
            }
            catch (Exception ex)
            {
                serializeResponseInfo = ex.ToString();

            }
            return serializeResponseInfo;
        }

        public string Get(string id)
        {
            string serializeResponseInfo = "";
            try
            {
                
            }
            catch (Exception ex)
            {
                serializeResponseInfo = ex.ToString();

            }
            return serializeResponseInfo;
        }
    }
}
