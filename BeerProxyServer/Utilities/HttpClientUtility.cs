using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BeerProxyServer.Utilities
{
    public static class HttpClientUtility
    {
        #region Private Members
        private static HttpClient _client;
        private static string _baseAddress = ConfigurationManager.AppSettings["BeerUrl"];
        private static string _privateKey = ConfigurationManager.AppSettings["PrivateKey"];
        private static NameValueCollection _params = new NameValueCollection();

        private static void Init()
        {
            _client = new HttpClient();

            SetDefautKeyForURI();
            SetDefaultHeadersForURI();
            SetBaseAddress();



        }

        private static void SetDefautKeyForURI()
        {
            if (_params.Count > 0)
            {
                _params.Clear();
            }
            _params.Add("key", _privateKey);
        }
        
        private static void SetDefaultHeadersForURI()
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            MediaTypeWithQualityHeaderValue jsonMediaType = new MediaTypeWithQualityHeaderValue("application/json");
            _client.DefaultRequestHeaders.Accept.Add(jsonMediaType);

        }

        private static void SetBaseAddress()
        {
            _client.BaseAddress = new Uri(_baseAddress);
        }

       
        #endregion

        #region Public Members


        public static HttpClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new HttpClient();
                }
                return _client;
            }
        }

        public static string GetURI(string apiController, string id)
        {
            Init();
            StringBuilder URL = new StringBuilder(_baseAddress);

           
            URL.Append(apiController);
            if (id != "" )
            {
                if (id.Contains("?"))
                {
                    URL.Append(id);
                    URL.Append("&key=" + HttpUtility.UrlEncode(_privateKey));
                }
                else {
                    URL.Append("/" + id);
                    URL.Append("?key=" + HttpUtility.UrlEncode(_privateKey));
                }
            }
            else
            {
                URL.Append("?key=" + HttpUtility.UrlEncode(_privateKey));

            }
           
            return URL.ToString();
        }

     
        #endregion
    }
}
