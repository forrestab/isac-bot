﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Isac.Api.Http
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetAsync<T>(this HttpClient client, string requestUri)
        {
            HttpResponseMessage Response = await client.GetAsync(requestUri);

            Response.EnsureSuccessStatusCode();

            return await Response.Content.ReadAsJsonAsync<T>();
        }

        public static async Task<T> PostAsync<T>(this HttpClient client, string requestUri, HttpContent content)
        {
            HttpResponseMessage Response = await client.PostAsync(requestUri, content);

            Response.EnsureSuccessStatusCode();

            return await Response.Content.ReadAsJsonAsync<T>();
        }

        public static async Task<T> PutAsync<T>(this HttpClient client, string requestUri, HttpContent content)
        {
            HttpResponseMessage Response = await client.PutAsync(requestUri, content);

            Response.EnsureSuccessStatusCode();

            return await Response.Content.ReadAsJsonAsync<T>();
        }
    }
}