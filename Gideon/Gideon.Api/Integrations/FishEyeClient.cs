﻿using Gideon.Api.Http;
using Gideon.Api.Models.FishEye;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gideon.Api.Integrations
{
    public class FishEyeClient : IFishEyeClient
    {
        private readonly HttpClient client;

        public FishEyeClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<FishEyeChangesets> GetReviewsForChangesets(string repositoryKey, List<string> commitIds)
        {
            string RequestUri = $"search-v1/reviewsForChangesets/{repositoryKey}";
            List<KeyValuePair<string, string>> ChangesetIds = new List<KeyValuePair<string, string>>();

            foreach (string CommitId in commitIds)
            {
                ChangesetIds.Add(new KeyValuePair<string, string>("cs", CommitId));
            }

            return await this.client.PostAsync<FishEyeChangesets>(RequestUri, new FormUrlEncodedContent(ChangesetIds));
        }
    }
}
