using System;
using System.ComponentModel.DataAnnotations;

namespace OptimCMSExtension
{
    public class OptimOldApiConfig
    {
        /// <summary>
        /// Provides configuration options for your call to the old OptimCMS Api
        /// </summary>
        /// <param name="group">The group name for the data that you want to pull. Can be a blank string.</param>
        /// <param name="subGroup">The subgroup name for the data that you want to pull. Can be a blank string.</param>
        /// <param name="apiKey">Your OptimCMS Api Key</param>
        public OptimOldApiConfig(string group, string subGroup, string apiKey)
        {
            ApiKey = apiKey;
            SubGroup = subGroup;
            Group = group;
        }

        /// <summary>
        /// Provides a blank configuration in which you can set the variables at a later time.  Must be done before calling the Api.
        /// </summary>
        public OptimOldApiConfig()
        {
        }

        public string Group { get; set; }
        public string SubGroup { get; set; }
        [Required]
        public string ApiKey { get; set; }
    }
}
