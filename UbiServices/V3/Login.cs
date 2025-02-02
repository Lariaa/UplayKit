﻿using Newtonsoft.Json;
using RestSharp;
using System.Text;
using UbiServices.Records;

namespace UbiServices.Public
{
    public partial class V3
    {
        public static readonly string AppID = "f68a4bb5-608a-4ff2-8123-be8ef797e0a6";
        public static string UserAgent = "Massgate";
        public static readonly string URL = "https://public-ubiservices.ubi.com/v3/profile/sessions";

        /// <summary>
        /// Login via Email and Password
        /// </summary>
        /// <param name="email">User email</param>
        /// <param name="password">User password</param>
        /// <returns>LoginJson or Null</returns>
        public static LoginJson? Login(string email, string password)
        {
            string b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{email}:{password}"));
            return LoginBase64(b64);
        }

        /// <summary>
        /// Login via Base64 mail and password
        /// </summary>
        /// <param name="b64">Base64 of Email:Password</param>
        /// <returns>LoginJson or Null</returns>
        public static LoginJson? LoginBase64(string b64)
        {
            var client = new RestClient(URL);
            var request = new RestRequest();

            request.AddHeader("Authorization", $"Basic {b64}");
            request.AddHeader("User-Agent", UserAgent);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Ubi-RequestedPlatformType", "uplay");
            request.AddHeader("Ubi-AppId", AppID);
            var rem = new
            {
                rememberMe = true
            };
            request.AddJsonBody(rem);

            RestResponse response = client.PostAsync(request).Result;

            if (response.Content != null)
            {
                return JsonConvert.DeserializeObject<LoginJson>(response.Content);
            }

            return null;
        }

        /// <summary>
        /// Login via 2FA ticket and Code
        /// </summary>
        /// <param name="tfaTicket">2FA Ticket</param>
        /// <param name="tfaCode">Code from Auth device (mail,google)</param>
        /// <returns>LoginJson or Null</returns>
        public static LoginJson? Login2FA(string tfaTicket, string tfaCode)
        {
            var client = new RestClient(URL);
            var request = new RestRequest();

            request.AddHeader("Authorization", $"ubi_2fa_v1 t={tfaTicket}");
            request.AddHeader("Ubi-2FACode", tfaCode);
            request.AddHeader("User-Agent", UserAgent);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Ubi-RequestedPlatformType", "uplay");
            request.AddHeader("Ubi-AppId", AppID);
            var rem = new
            {
                rememberMe = true
            };
            request.AddJsonBody(rem);

            RestResponse response = client.PostAsync(request).Result;

            if (response.Content != null)
            {
                return JsonConvert.DeserializeObject<LoginJson>(response.Content);
            }

            return null;
        }

        /// <summary>
        /// Login via Remember Ticket
        /// </summary>
        /// <param name="rememberTicket">Remember Ticket</param>
        /// <returns>LoginJson or Null</returns>
        public static LoginJson? LoginRemember(string rememberTicket)
        {
            var client = new RestClient(URL);
            var request = new RestRequest();

            request.AddHeader("Authorization", $"rm_v1 t={rememberTicket}");
            request.AddHeader("User-Agent", UserAgent);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Ubi-RequestedPlatformType", "uplay");
            request.AddHeader("Ubi-AppId", AppID);
            var rem = new
            {
                rememberMe = true
            };
            request.AddJsonBody(rem);

            RestResponse response = client.PostAsync(request).Result;

            if (response.Content != null)
            {
                return JsonConvert.DeserializeObject<LoginJson>(response.Content);
            }

            return null;
        }

        /// <summary>
        /// Login via Rem Ticket and Device ticket
        /// </summary>
        /// <param name="rememberTicket">Remember Ticket</param>
        /// <param name="rememberDeviceTicket">Device Ticket</param>
        /// <returns>LoginJson or Null</returns>
        public static LoginJson? LoginRememberDevice(string rememberTicket, string rememberDeviceTicket)
        {
            var client = new RestClient(URL);
            var request = new RestRequest();

            request.AddHeader("Authorization", $"rm_v1 t={rememberTicket}");
            request.AddHeader("User-Agent", UserAgent);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Ubi-RequestedPlatformType", "uplay");
            request.AddHeader("Ubi-AppId", AppID);
            request.AddHeader("Ubi-RememberDeviceTicket", rememberDeviceTicket);
            var rem = new
            {
                rememberMe = true
            };
            request.AddJsonBody(rem);

            RestResponse response = client.PostAsync(request).Result;

            if (response.Content != null)
            {
                return JsonConvert.DeserializeObject<LoginJson>(response.Content);
            }

            return null;
        }
    }
}