using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBiblioteka.Model;
using Flurl.Http;
using Flurl;
using eBiblioteka.WinUI.Properties;
using Microsoft.AspNetCore.Mvc;

namespace eBiblioteka.WinUI
{
    public class APIService
    {
        private string _resource;
        public string endpoint = $"{Resources.ApiUrl}";

        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Zaposlenik CurrentUser { get; set; }

        public APIService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> GetAll<T>(object searchRequest = null, string action = null)
        {
            var query = "";
            if (searchRequest != null)
            {
                query = await searchRequest?.ToQueryString();
            }

            var list = await ($"{endpoint}{_resource}" + (action != null ? "/" + action : "") + $"?{query}")
               .WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return list;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{endpoint}{_resource}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{endpoint}{_resource}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var stringBuilder = new StringBuilder();
                try
                {
                    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                    foreach (var error in errors)
                    {
                        stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                    }
                }
                catch (Exception)
                {
                    var errors = await ex.GetResponseStringAsync();

                    stringBuilder.AppendLine(errors);
                }
                if (stringBuilder.Length > 0)
                    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request, string action = null)
        {
            try
            {
                var url = $"{endpoint}{_resource}" + (action != null ? "/" + action : "") + $"/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var stringBuilder = new StringBuilder();
                try
                {
                    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                    foreach (var error in errors)
                    {
                        stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                    }
                }
                catch (Exception)
                {
                    var errors = await ex.GetResponseStringAsync();

                    stringBuilder.AppendLine(errors);
                }
                if (stringBuilder.Length > 0)
                    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return default(T);
            }

        }

        public async Task<T> Delete<T>(object id)
        {
            var url = $"{endpoint}{_resource}/{id}";

            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
        }
    }

}
