using System;
using System.ComponentModel.DataAnnotations;

namespace OptimCMSExtension
{
    public class OptimOldApiConfig
    {
        public OptimOldApiConfig(string group, string subGroup, string apiKey)
        {
            ApiKey = apiKey;
            SubGroup = subGroup;
            Group = group;
        }

        public OptimOldApiConfig()
        {
        }

        public string Group { get; set; }
        public string SubGroup { get; set; }
        [Required]
        public string ApiKey { get; set; }
    }
}
