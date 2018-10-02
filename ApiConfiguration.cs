using System;
using System.ComponentModel.DataAnnotations;

namespace OptimCMSExtension
{
    public class OptimApiConfig
    {
        public OptimApiConfig(string projectId, string schema, string apiKey)
        {
            ApiKey = apiKey;
            Schema = schema;
            ProjectId = projectId;
        }

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
