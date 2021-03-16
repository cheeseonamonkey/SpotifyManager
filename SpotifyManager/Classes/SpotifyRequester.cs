using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyManager
{
    public class SpotifyRequester
    {
        HttpClient client;

        public SpotifyRequester()
        {
            client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> TestGet()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (Globals.AccessToken != null)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Globals.AccessToken.access_token);

            HttpResponseMessage response = await client.GetAsync("https://api.spotify.com/v1/me");

            if(response.IsSuccessStatusCode)
            {
                return true;
            }else
            {
                Console.WriteLine($"Test get error - {response.StatusCode}");
                return false;
            }
        }

        public async Task<string> MakeRequestAsync(string url, string parameters = "")
        {
            if(Globals.AccessToken != null   &&   client.DefaultRequestHeaders.Authorization.Parameter != Globals.AccessToken.access_token)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Globals.AccessToken.access_token);

            //todo: access token bug debug output:

            Console.WriteLine(url);
            Console.WriteLine($"\tAuth:  {client.DefaultRequestHeaders.Authorization}");

            

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                //
            }
            else
            {
                MessageBox.Show($"HTTP error -  {response.StatusCode}");
            }


            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }

        

        public static async Task<AccessToken> GetAccessTokenAsync(string authCode)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "NjZlMWNjNmY2MjE1NDM0MDk2NjU4MTAzM2NiZTg0ZTg6MTE0MjE4OWI4YzUwNGMwN2ExZGRmYzA4OGVlYjM2MWI");

            List<KeyValuePair<string, string>> requestData = new List<KeyValuePair<string, string>>();
            requestData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            requestData.Add(new KeyValuePair<string, string>("code", authCode));
            requestData.Add(new KeyValuePair<string, string>("redirect_uri", "http://localhost/"));

            FormUrlEncodedContent requestBody = new FormUrlEncodedContent(requestData);

            HttpResponseMessage response = await client.PostAsync("https://accounts.spotify.com/api/token", requestBody);

            string responseData = await response.Content.ReadAsStringAsync();
            
            client.Dispose();

            //Console.WriteLine(responseData);

            return JsonConvert.DeserializeObject<AccessToken>(responseData);
        }
    }
}
