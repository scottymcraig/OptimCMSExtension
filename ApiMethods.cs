using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace OptimCMSExtension
{
    public static class OptimCMS
    {
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
