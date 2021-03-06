
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace goose2s
{
    public static class AuthContants {
        private static string generateRandomString(int length) {
            var text = "";
            var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (var i = 0; i < length; i++) {
                text += possible[new Random().Next(0, possible.Length)];
            }
            return text;
        }

        public static Dictionary<string,string> GetAuthKeys(IConfiguration config) {
            var callbackUri = config["AppSettings:CallbackUri"];
            var clientId = config["AppSettings:SpotifyClientId"];
            var clientSecret = config["AppSettings:SpotifyClientSecret"];
                return new Dictionary<string,string> {
                    { "response_type", "code" },
                    { "client_id", clientId },
                    { "client_secret", clientSecret },
                    { "scope", "user-read-playback-state user-modify-playback-state user-read-private" },
                    { "redirect_uri", callbackUri },
                    { "state", generateRandomString(16) }
                };
        }
    }
}