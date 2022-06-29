
using AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AFS_TRANSLATOR.DAL.ExternalApiCalls.FunTranslations.Translate.Concrete
{
    public class TranslateApiCalls : ITranslateApiCalls
    {
        private const string _baseUrl = "https://api.funtranslations.com/translate";

        public async Task<dynamic> Translate(string endpoint, dynamic body)
        {
            string urlEdited = $"{_baseUrl}/{endpoint}";
            using (var client = new HttpClient())
            {
                var serializeBody = JsonConvert.SerializeObject(body);

                var payLoad = new StringContent(serializeBody, Encoding.UTF8, "application/json");

                var result = client.PostAsync(urlEdited, payLoad).Result.Content.ReadAsStringAsync().Result;

                var resultObject = JsonConvert.DeserializeObject<dynamic>(result);
              
                return resultObject;
            }
        }

    }
}
