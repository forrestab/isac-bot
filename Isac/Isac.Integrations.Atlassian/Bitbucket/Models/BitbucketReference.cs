﻿using Isac.Integrations.Atlassian.Bitbucket.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Isac.Integrations.Atlassian.Bitbucket.Models
{
    public class BitbucketReference
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayId")]
        public string DisplayName { get; set; }

        // TODO, check if in all objects
        [JsonProperty("latestCommit")]
        public string LatestCommit { get; set; }

        // TODO, check if in all objects
        [JsonProperty("repository")]
        public BitbucketRepository Repository { get; set; }

        // TODO, check if in all objects
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BitbucketReferenceType ReferenceType { get; set; }
    }
}