using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProxyServer.DTO;
using System.Net.Http;
using BeerProxyServer.Utilities;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace BeerProxyServer.Controller
{
    public class BeerController
    {
        #region privateFunctions

        // to fetch data for a given beer and will return the BeerInfo
        private static async Task<BeerResponseInfo> GetBeerResponse(string proxyController, string id = "")
        {
            BeerResponseInfo beerResponeInfo = null;
            //string jsonData = null;
            try
            {
                HttpClient client = HttpClientUtility.Client;
                string URI = HttpClientUtility.GetURI(proxyController, id);
                using (HttpResponseMessage response = await client.GetAsync(URI).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        beerResponeInfo = await response.Content.ReadAsAsync<BeerResponseInfo>();

                    }
                    else
                    {
                        beerResponeInfo = new BeerResponseInfo();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return beerResponeInfo;


        }

        // to fetch data for all the Beers .. subset  
        private async Task<BeersResponseInfo> GetBeersResponse(string proxyController, string id = "")
        {
            BeersResponseInfo beersResponeInfo = null;

            try
            {
                HttpClient client = HttpClientUtility.Client;

                string URI = HttpClientUtility.GetURI(proxyController, id);

                using (HttpResponseMessage response = await client.GetAsync(URI).ConfigureAwait(false))
                {

                    response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        beersResponeInfo = await response.Content.ReadAsAsync<BeersResponseInfo>();

                    }
                    else
                    {
                        beersResponeInfo = new BeersResponseInfo();
                        throw new ApplicationException("Error code " + response.StatusCode.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return beersResponeInfo;


        }

        // to searh the beer details 
        // id contains --> keyword and type of beer
        private async Task<BeerSearchResponseInfo> SearchTheBeerForGivenTypeAndKeyWord(string proxyController, string id = "")
        {

            BeerSearchResponseInfo beerResponeInfo = null;
            //string jsonData = null;
            try
            {
                HttpClient client = HttpClientUtility.Client;
                string URI = HttpClientUtility.GetURI(proxyController, id);


                using (HttpResponseMessage response = await client.GetAsync(URI).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        string responseData = await response.Content.ReadAsStringAsync();
                        beerResponeInfo =(BeerSearchResponseInfo)JsonConvert.DeserializeObject<BeerSearchResponseInfo>(responseData);

                        beerResponeInfo = await response.Content.ReadAsAsync<BeerSearchResponseInfo>();

                    }
                    else
                    {
                        beerResponeInfo = new BeerSearchResponseInfo();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return beerResponeInfo;


        }

        #endregion

        #region publicFunctions

        public async Task<BeerResponseInfo> GetBeerData(string proxyController, string id)
        {
            //var result = await SendGetRequest(proxyController, id);
            BeerResponseInfo result = await GetBeerResponse(proxyController, id).ConfigureAwait(false);
            return result;
        }


        public async Task<BeersResponseInfo> GetAllBeerData(string proxyController, string id)
        {
            //var result = await SendGetRequest(proxyController, id);
            BeersResponseInfo result = await GetBeersResponse(proxyController, id).ConfigureAwait(false);
            return result;
        }

        public async Task<BeerSearchResponseInfo> SearchTheBeer(String proxyController, string id)
        {
            BeerSearchResponseInfo result = await SearchTheBeerForGivenTypeAndKeyWord(proxyController, id).ConfigureAwait(false);
            return result;


        }

        #endregion
    }
}
 
