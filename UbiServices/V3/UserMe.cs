﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using UbiServices.Records;
using UbiServices.Store;

namespace UbiServices.Public
{
    public partial class V3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public static UsersMe? GetUsersMe(string token, string sessionId)
        {
            string URL = $"https://public-ubiservices.ubi.com/v3/users/me";
            var client = new RestClient(URL);
            var request = new RestRequest();

            request.AddHeader("Ubi-AppId", AppID);
            request.AddHeader("Authorization", "Ubi_v1 t=" + token);
            request.AddHeader("Ubi-SessionId", sessionId);
            RestResponse response = client.GetAsync(request).Result;
            if (response.Content != null)
            {
                return JsonConvert.DeserializeObject<UsersMe>(response.Content);
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <param name="sessionId"></param>
        /// <param name="UserId"></param>
        /// <param name="fields">NotImplementedYet</param>
        /// <returns></returns>
        public static JObject? GetUsersMeById(string token, string sessionId,string UserId,List<string> fields)
        {
            string URL = $"https://public-ubiservices.ubi.com/v3/users/{UserId}";

            
            if (fields == null || fields.Count == 0)
            {
                //Just normal request should do anything
            }
            else
            {
                var filedscommas = String.Join(",", fields);
                URL += "?fields=" + filedscommas;
            }

            var client = new RestClient(URL);
            var request = new RestRequest();

            request.AddHeader("Ubi-AppId", AppID);
            request.AddHeader("Authorization", "Ubi_v1 t=" + token);
            request.AddHeader("Ubi-SessionId", sessionId);
            RestResponse response = client.GetAsync(request).Result;
            if (response.Content != null)
            {
                return JObject.Parse(response.Content);
            }
            return null;
        }
    }
}
