using System;
using System.ComponentModel.DataAnnotations;

namespace OptimCMSExtension
{
    public class OptimApiConfig
    {
        /// <summary>
        /// Provides configuration options for your call to the new OptimCMS Api
        /// </summary>
        /// <param name="projectId">The project ID of the data you want to pull</param>
        /// <param name="schema">The schema ID of the data that you want to pull</param>
        /// <param name="apiKey">Your OptimCMS Api Key</param>
        public OptimApiConfig(string projectId, string schema, string apiKey)
        {
            ApiKey = apiKey;
            Schema = schema;
            ProjectId = projectId;
        }

        /// <summary>
        /// Provides a blank configuration in which you can set the variables at a later time.  Must be done before calling the Api.
        /// </summary>
        public OptimApiConfig()
        {
        }

        [Required]
        public string ProjectId { get; set; }
        [Required]
        public string Schema { get; set; }
        [Required]
        public string ApiKey { get; set; }
    }
}
