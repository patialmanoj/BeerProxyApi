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
        BeerController beerController = new BeerController();
        private string proxyController = "";

        public string Get()
        {
            string serializeResponseInfo = "";
            try
            {
                proxyController = ConfigurationManager.AppSettings["BeersController"].ToString();
                BeersResponseInfo beersResponseInfo = beerController.GetAllBeerData(proxyController, "").Result;
                serializeResponseInfo = JsonConvert.SerializeObject(beersResponseInfo);
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
                proxyController = ConfigurationManager.AppSettings["BeerController"].ToString();
                BeerResponseInfo beerResponseInfo = beerController.GetBeerData(proxyController, id).Result;
                // can do massaging if required
                serializeResponseInfo = JsonConvert.SerializeObject(beerResponseInfo); ;
            }
            catch (Exception ex)
            {
                serializeResponseInfo = ex.ToString();

            }
            return serializeResponseInfo;
        }
    }
}
