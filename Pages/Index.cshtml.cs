using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TZones.Pages
{
    public class TimeZoneModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public TimeZoneModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<SelectListItem> TimeZones { get; set; }
        [BindProperty]
        public string SelectedTimeZone { get; set; }
        public string ApiResponse { get; set; }

        public void OnGet()
        {
            TimeZones = new List<SelectListItem>
            {
                new SelectListItem { Value = "America/New_York", Text = "America/New_York" },
                new SelectListItem { Value = "Europe/London", Text = "Europe/London" },
                new SelectListItem { Value = "Asia/Tokyo", Text = "Asia/Tokyo" }
                // Add more time zones as needed
            };
        }

        public async Task OnPostAsync()
        {
            if (!string.IsNullOrEmpty(SelectedTimeZone))
            { using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync($"https://timeapi.io/api/TimeZone/zone?timeZone={SelectedTimeZone}");
                    var data = JObject.Parse(response);
                    string timeZone = data["currentLocalTime"].Value<string>();

                    ApiResponse = timeZone;
                }
            }
        }
    }
}