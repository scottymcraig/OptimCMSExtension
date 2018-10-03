using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace OptimCMSExtension
{
    public static class OptimCMS
    {
        /// <summary>
        /// Method to get data from the old OptimCMS Api
        /// </summary>
        /// <param name="myconfiguration">Configuration data to be passed to the Api</param>
        /// <returns>Returns a string with the HTML output of your call</returns>
        public static async Task<string> OptimOldApiData(OptimOldApiConfig myconfiguration)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.optim-cms.com/");
                    var response = await client.GetAsync("?group="+ WebUtility.UrlEncode(myconfiguration.Group) +"&subgroup="
                                                         + WebUtility.UrlEncode(myconfiguration.SubGroup)
                                                         +"&apikey="+ WebUtility.UrlEncode(myconfiguration.ApiKey));
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                {
                    return "Exception occurred in request: " + e.Message;
                }
            }
        }

        /// <summary>
        /// Method to get data from the new OptimCMS Api
        /// </summary>
        /// <param name="myconfiguration">Configuration data to be passed to the Api</param>
        /// <returns>Returns a string with the HTML output of your call</returns>
        public static async Task<string> OptimApiData(OptimApiConfig myconfiguration)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.optim-cms.com/");
                    var data = new Dictionary<string, string>
                    {
                        {"ApiKey", myconfiguration.ApiKey},
                        {"SchemaName", myconfiguration.Schema}
                    };
                    var response = await client.PostAsync(myconfiguration.ProjectId, new FormUrlEncodedContent(data));
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                {
                    return "Exception occurred in request: " + e.Message;
                }
            }
        }
    }
}
