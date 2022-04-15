using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Json;

namespace BelajarBlazor.Client.Services
{
    public class LoginService : ILoginService
    {
        private readonly HttpClient _httpClient;    
        public LoginService(HttpClient http)
        {
            _httpClient = http; 
        }

        public User users { get; set; }

        public async Task Login(User user)
        {
            var result = await _httpClient.PostAsJsonAsync(new Uri("https://localhost:44339/api/Login") , user);
            if (result.IsSuccessStatusCode)
            {
    
                var response = await result.Content.ReadAsStringAsync();
                users = JsonConvert.DeserializeObject<User>(response);
            }
        }
    }
}
