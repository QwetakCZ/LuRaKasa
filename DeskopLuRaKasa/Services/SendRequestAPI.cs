using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DeskopLuRaKasa.ViewModels;

namespace DeskopLuRaKasa.Services
{
    public class SendRequestAPI
    {
        
        private readonly GlobalViewModel _globalViewModel;
        private MyHttpClient _client;

        public SendRequestAPI(GlobalViewModel globalViewModel)
        {
            _globalViewModel = globalViewModel;
        }

        public async Task<string> LoginToStringAsync(string username, string password)
        {
           _client = new MyHttpClient();
           string result;
            try
            {
                result = await _client.GetStringAsync($"User/Login?username={username}&password={password}");

                if (string.IsNullOrEmpty(result))
                {
                    return _globalViewModel.LoginFailed;
                }

            }
            catch (Exception)
            {
                return _globalViewModel.LoginFailed;
            }
            finally
            {
                _client.Dispose();
            }
            return result;
        }
    }
}
