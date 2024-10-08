﻿using Microsoft.AspNetCore.Mvc;
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

        public string ApiDayTime {  get; set; }
        public string ApiResponseTime { get; set; }
        public string ApiResponseName { get; set; }

        public void OnGet()
        {
            TimeZones = new List<SelectListItem>
            {
 // Africa
new SelectListItem { Value = "Africa/Abidjan", Text = "Africa/Abidjan" },
new SelectListItem { Value = "Africa/Accra", Text = "Africa/Accra" },
new SelectListItem { Value = "Africa/Addis_Ababa", Text = "Africa/Addis_Ababa" },
new SelectListItem { Value = "Africa/Algiers", Text = "Africa/Algiers" },
new SelectListItem { Value = "Africa/Asmara", Text = "Africa/Asmara" },
new SelectListItem { Value = "Africa/Bamako", Text = "Africa/Bamako" },
new SelectListItem { Value = "Africa/Bangui", Text = "Africa/Bangui" },
new SelectListItem { Value = "Africa/Banjul", Text = "Africa/Banjul" },
new SelectListItem { Value = "Africa/Bissau", Text = "Africa/Bissau" },
new SelectListItem { Value = "Africa/Blantyre", Text = "Africa/Blantyre" },
new SelectListItem { Value = "Africa/Brazzaville", Text = "Africa/Brazzaville" },
new SelectListItem { Value = "Africa/Bujumbura", Text = "Africa/Bujumbura" },
new SelectListItem { Value = "Africa/Cairo", Text = "Africa/Cairo" },
new SelectListItem { Value = "Africa/Casablanca", Text = "Africa/Casablanca" },
new SelectListItem { Value = "Africa/Ceuta", Text = "Africa/Ceuta" },
new SelectListItem { Value = "Africa/Conakry", Text = "Africa/Conakry" },
new SelectListItem { Value = "Africa/Dakar", Text = "Africa/Dakar" },
new SelectListItem { Value = "Africa/Dar_es_Salaam", Text = "Africa/Dar_es_Salaam" },
new SelectListItem { Value = "Africa/Djibouti", Text = "Africa/Djibouti" },
new SelectListItem { Value = "Africa/Douala", Text = "Africa/Douala" },
new SelectListItem { Value = "Africa/El_Aaiun", Text = "Africa/El_Aaiun" },
new SelectListItem { Value = "Africa/Freetown", Text = "Africa/Freetown" },
new SelectListItem { Value = "Africa/Gaborone", Text = "Africa/Gaborone" },
new SelectListItem { Value = "Africa/Harare", Text = "Africa/Harare" },
new SelectListItem { Value = "Africa/Johannesburg", Text = "Africa/Johannesburg" },
new SelectListItem { Value = "Africa/Juba", Text = "Africa/Juba" },
new SelectListItem { Value = "Africa/Kampala", Text = "Africa/Kampala" },
new SelectListItem { Value = "Africa/Khartoum", Text = "Africa/Khartoum" },
new SelectListItem { Value = "Africa/Kigali", Text = "Africa/Kigali" },
new SelectListItem { Value = "Africa/Kinshasa", Text = "Africa/Kinshasa" },
new SelectListItem { Value = "Africa/Lagos", Text = "Africa/Lagos" },
new SelectListItem { Value = "Africa/Libreville", Text = "Africa/Libreville" },
new SelectListItem { Value = "Africa/Lome", Text = "Africa/Lome" },
new SelectListItem { Value = "Africa/Luanda", Text = "Africa/Luanda" },
new SelectListItem { Value = "Africa/Lubumbashi", Text = "Africa/Lubumbashi" },
new SelectListItem { Value = "Africa/Lusaka", Text = "Africa/Lusaka" },
new SelectListItem { Value = "Africa/Malabo", Text = "Africa/Malabo" },
new SelectListItem { Value = "Africa/Maputo", Text = "Africa/Maputo" },
new SelectListItem { Value = "Africa/Maseru", Text = "Africa/Maseru" },
new SelectListItem { Value = "Africa/Mbabane", Text = "Africa/Mbabane" },
new SelectListItem { Value = "Africa/Mogadishu", Text = "Africa/Mogadishu" },
new SelectListItem { Value = "Africa/Monrovia", Text = "Africa/Monrovia" },
new SelectListItem { Value = "Africa/Nairobi", Text = "Africa/Nairobi" },
new SelectListItem { Value = "Africa/Ndjamena", Text = "Africa/Ndjamena" },
new SelectListItem { Value = "Africa/Niamey", Text = "Africa/Niamey" },
new SelectListItem { Value = "Africa/Nouakchott", Text = "Africa/Nouakchott" },
new SelectListItem { Value = "Africa/Ouagadougou", Text = "Africa/Ouagadougou" },
new SelectListItem { Value = "Africa/Porto-Novo", Text = "Africa/Porto-Novo" },
new SelectListItem { Value = "Africa/Sao_Tome", Text = "Africa/Sao_Tome" },
new SelectListItem { Value = "Africa/Tripoli", Text = "Africa/Tripoli" },
new SelectListItem { Value = "Africa/Tunis", Text = "Africa/Tunis" },
new SelectListItem { Value = "Africa/Windhoek", Text = "Africa/Windhoek" },

// America
new SelectListItem { Value = "America/Adak", Text = "America/Adak" },
new SelectListItem { Value = "America/Anchorage", Text = "America/Anchorage" },
new SelectListItem { Value = "America/Anguilla", Text = "America/Anguilla" },
new SelectListItem { Value = "America/Antigua", Text = "America/Antigua" },
new SelectListItem { Value = "America/Araguaina", Text = "America/Araguaina" },
new SelectListItem { Value = "America/Argentina/Buenos_Aires", Text = "America/Argentina/Buenos_Aires" },
new SelectListItem { Value = "America/Argentina/Catamarca", Text = "America/Argentina/Catamarca" },
new SelectListItem { Value = "America/Argentina/Cordoba", Text = "America/Argentina/Cordoba" },
new SelectListItem { Value = "America/Argentina/Jujuy", Text = "America/Argentina/Jujuy" },
new SelectListItem { Value = "America/Argentina/La_Rioja", Text = "America/Argentina/La_Rioja" },
new SelectListItem { Value = "America/Argentina/Mendoza", Text = "America/Argentina/Mendoza" },
new SelectListItem { Value = "America/Argentina/Rio_Gallegos", Text = "America/Argentina/Rio_Gallegos" },
new SelectListItem { Value = "America/Argentina/Salta", Text = "America/Argentina/Salta" },
new SelectListItem { Value = "America/Argentina/San_Juan", Text = "America/Argentina/San_Juan" },
new SelectListItem { Value = "America/Argentina/San_Luis", Text = "America/Argentina/San_Luis" },
new SelectListItem { Value = "America/Argentina/Tucuman", Text = "America/Argentina/Tucuman" },
new SelectListItem { Value = "America/Argentina/Ushuaia", Text = "America/Argentina/Ushuaia" },
new SelectListItem { Value = "America/Aruba", Text = "America/Aruba" },
new SelectListItem { Value = "America/Asuncion", Text = "America/Asuncion" },
new SelectListItem { Value = "America/Atikokan", Text = "America/Atikokan" },
new SelectListItem { Value = "America/Bahia", Text = "America/Bahia" },
new SelectListItem { Value = "America/Bahia_Banderas", Text = "America/Bahia_Banderas" },
new SelectListItem { Value = "America/Barbados", Text = "America/Barbados" },
new SelectListItem { Value = "America/Belem", Text = "America/Belem" },
new SelectListItem { Value = "America/Belize", Text = "America/Belize" },
new SelectListItem { Value = "America/Blanc-Sablon", Text = "America/Blanc-Sablon" },
new SelectListItem { Value = "America/Boa_Vista", Text = "America/Boa_Vista" },
new SelectListItem { Value = "America/Bogota", Text = "America/Bogota" },
new SelectListItem { Value = "America/Boise", Text = "America/Boise" },
new SelectListItem { Value = "America/Cambridge_Bay", Text = "America/Cambridge_Bay" },
new SelectListItem { Value = "America/Campo_Grande", Text = "America/Campo_Grande" },
new SelectListItem { Value = "America/Cancun", Text = "America/Cancun" },
new SelectListItem { Value = "America/Caracas", Text = "America/Caracas" },
new SelectListItem { Value = "America/Cayenne", Text = "America/Cayenne" },
new SelectListItem { Value = "America/Cayman", Text = "America/Cayman" },
new SelectListItem { Value = "America/Chicago", Text = "America/Chicago" },
new SelectListItem { Value = "America/Chihuahua", Text = "America/Chihuahua" },
new SelectListItem { Value = "America/Costa_Rica", Text = "America/Costa_Rica" },
new SelectListItem { Value = "America/Creston", Text = "America/Creston" },
new SelectListItem { Value = "America/Cuiaba", Text = "America/Cuiaba" },
new SelectListItem { Value = "America/Curacao", Text = "America/Curacao" },
new SelectListItem { Value = "America/Danmarkshavn", Text = "America/Danmarkshavn" },
new SelectListItem { Value = "America/Dawson", Text = "America/Dawson" },
new SelectListItem { Value = "America/Dawson_Creek", Text = "America/Dawson_Creek" },
new SelectListItem { Value = "America/Denver", Text = "America/Denver" },
new SelectListItem { Value = "America/Detroit", Text = "America/Detroit" },
new SelectListItem { Value = "America/Dominica", Text = "America/Dominica" },
new SelectListItem { Value = "America/Edmonton", Text = "America/Edmonton" },
new SelectListItem { Value = "America/Eirunepe", Text = "America/Eirunepe" },
new SelectListItem { Value = "America/El_Salvador", Text = "America/El_Salvador" },
new SelectListItem { Value = "America/Fortaleza", Text = "America/Fortaleza" },
new SelectListItem { Value = "America/Glace_Bay", Text = "America/Glace_Bay" },
new SelectListItem { Value = "America/Godthab", Text = "America/Godthab" },
new SelectListItem { Value = "America/Goose_Bay", Text = "America/Goose_Bay" },
new SelectListItem { Value = "America/Grand_Turk", Text = "America/Grand_Turk" },
new SelectListItem { Value = "America/Grenada", Text = "America/Grenada" },
new SelectListItem { Value = "America/Guadeloupe", Text = "America/Guadeloupe" },
new SelectListItem { Value = "America/Guatemala", Text = "America/Guatemala" },
new SelectListItem { Value = "America/Guayaquil", Text = "America/Guayaquil" },
new SelectListItem { Value = "America/Guyana", Text = "America/Guyana" },
new SelectListItem { Value = "America/Halifax", Text = "America/Halifax" },
new SelectListItem { Value = "America/Havana", Text = "America/Havana" },
new SelectListItem { Value = "America/Hermosillo", Text = "America/Hermosillo" },
new SelectListItem { Value = "America/Indiana/Indianapolis", Text = "America/Indiana/Indianapolis" },
new SelectListItem { Value = "America/Indiana/Knox", Text = "America/Indiana/Knox" },
new SelectListItem { Value = "America/Indiana/Marengo", Text = "America/Indiana/Marengo" },
new SelectListItem { Value = "America/Indiana/Petersburg", Text = "America/Indiana/Petersburg" },
new SelectListItem { Value = "America/Indiana/Tell_City", Text = "America/Indiana/Tell_City" },
new SelectListItem { Value = "America/Indiana/Vevay", Text = "America/Indiana/Vevay" },
new SelectListItem { Value = "America/Indiana/Vincennes", Text = "America/Indiana/Vincennes" },
new SelectListItem { Value = "America/Indiana/Winamac", Text = "America/Indiana/Winamac" },
new SelectListItem { Value = "America/Inuvik", Text = "America/Inuvik" },
new SelectListItem { Value = "America/Iqaluit", Text = "America/Iqaluit" },
new SelectListItem { Value = "America/Jamaica", Text = "America/Jamaica" },
new SelectListItem { Value = "America/Juneau", Text = "America/Juneau" },
new SelectListItem { Value = "America/Kentucky/Louisville", Text = "America/Kentucky/Louisville" },
new SelectListItem { Value = "America/Kentucky/Monticello", Text = "America/Kentucky/Monticello" },
new SelectListItem { Value = "America/Kralendijk", Text = "America/Kralendijk" },
new SelectListItem { Value = "America/La_Paz", Text = "America/La_Paz" },
new SelectListItem { Value = "America/Lima", Text = "America/Lima" },
new SelectListItem { Value = "America/Los_Angeles", Text = "America/Los_Angeles" },
new SelectListItem { Value = "America/Lower_Princes", Text = "America/Lower_Princes" },
new SelectListItem { Value = "America/Maceio", Text = "America/Maceio" },
new SelectListItem { Value = "America/Managua", Text = "America/Managua" },
new SelectListItem { Value = "America/Manaus", Text = "America/Manaus" },
new SelectListItem { Value = "America/Marigot", Text = "America/Marigot" },
new SelectListItem { Value = "America/Martinique", Text = "America/Martinique" },
new SelectListItem { Value = "America/Matamoros", Text = "America/Matamoros" },
new SelectListItem { Value = "America/Mazatlan", Text = "America/Mazatlan" },
new SelectListItem { Value = "America/Menominee", Text = "America/Menominee" },
new SelectListItem { Value = "America/Merida", Text = "America/Merida" },
new SelectListItem { Value = "America/Metlakatla", Text = "America/Metlakatla" },
new SelectListItem { Value = "America/Mexico_City", Text = "America/Mexico_City" },
new SelectListItem { Value = "America/Miquelon", Text = "America/Miquelon" },
new SelectListItem { Value = "America/Moncton", Text = "America/Moncton" },
new SelectListItem { Value = "America/Monterrey", Text = "America/Monterrey" },
new SelectListItem { Value = "America/Montevideo", Text = "America/Montevideo" },
new SelectListItem { Value = "America/Montserrat", Text = "America/Montserrat" },
new SelectListItem { Value = "America/Nassau", Text = "America/Nassau" },
new SelectListItem { Value = "America/New_York", Text = "America/New_York" },
new SelectListItem { Value = "America/Nipigon", Text = "America/Nipigon" },
new SelectListItem { Value = "America/Nome", Text = "America/Nome" },
new SelectListItem { Value = "America/Noronha", Text = "America/Noronha" },
new SelectListItem { Value = "America/North_Dakota/Beulah", Text = "America/North_Dakota/Beulah" },
new SelectListItem { Value = "America/North_Dakota/Center", Text = "America/North_Dakota/Center" },
new SelectListItem { Value = "America/North_Dakota/New_Salem", Text = "America/North_Dakota/New_Salem" },
new SelectListItem { Value = "America/Nuuk", Text = "America/Nuuk" },
new SelectListItem { Value = "America/Ojinaga", Text = "America/Ojinaga" },
new SelectListItem { Value = "America/Panama", Text = "America/Panama" },
new SelectListItem { Value = "America/Pangnirtung", Text = "America/Pangnirtung" },
new SelectListItem { Value = "America/Paramaribo", Text = "America/Paramaribo" },
new SelectListItem { Value = "America/Phoenix", Text = "America/Phoenix" },
new SelectListItem { Value = "America/Port-au-Prince", Text = "America/Port-au-Prince" },
new SelectListItem { Value = "America/Port_of_Spain", Text = "America/Port_of_Spain" },
new SelectListItem { Value = "America/Porto_Velho", Text = "America/Porto_Velho" },
new SelectListItem { Value = "America/Puerto_Rico", Text = "America/Puerto_Rico" },
new SelectListItem { Value = "America/Punta_Arenas", Text = "America/Punta_Arenas" },
new SelectListItem { Value = "America/Rainy_River", Text = "America/Rainy_River" },
new SelectListItem { Value = "America/Rankin_Inlet", Text = "America/Rankin_Inlet" },
new SelectListItem { Value = "America/Recife", Text = "America/Recife" },
new SelectListItem { Value = "America/Regina", Text = "America/Regina" },
new SelectListItem { Value = "America/Resolute", Text = "America/Resolute" },
new SelectListItem { Value = "America/Rio_Branco", Text = "America/Rio_Branco" },
new SelectListItem { Value = "America/Santarem", Text = "America/Santarem" },
new SelectListItem { Value = "America/Santiago", Text = "America/Santiago" },
new SelectListItem { Value = "America/Santo_Domingo", Text = "America/Santo_Domingo" },
new SelectListItem { Value = "America/Sao_Paulo", Text = "America/Sao_Paulo" },
new SelectListItem { Value = "America/Scoresbysund", Text = "America/Scoresbysund" },
new SelectListItem { Value = "America/Sitka", Text = "America/Sitka" },
new SelectListItem { Value = "America/St_Barthelemy", Text = "America/St_Barthelemy" },
new SelectListItem { Value = "America/St_Johns", Text = "America/St_Johns" },
new SelectListItem { Value = "America/St_Kitts", Text = "America/St_Kitts" },
new SelectListItem { Value = "America/St_Lucia", Text = "America/St_Lucia" },
new SelectListItem { Value = "America/St_Thomas", Text = "America/St_Thomas" },
new SelectListItem { Value = "America/St_Vincent", Text = "America/St_Vincent" },
new SelectListItem { Value = "America/Swift_Current", Text = "America/Swift_Current" },
new SelectListItem { Value = "America/Tegucigalpa", Text = "America/Tegucigalpa" },
new SelectListItem { Value = "America/Thule", Text = "America/Thule" },
new SelectListItem { Value = "America/Thunder_Bay", Text = "America/Thunder_Bay" },
new SelectListItem { Value = "America/Tijuana", Text = "America/Tijuana" },
new SelectListItem { Value = "America/Toronto", Text = "America/Toronto" },
new SelectListItem { Value = "America/Tortola", Text = "America/Tortola" },
new SelectListItem { Value = "America/Vancouver", Text = "America/Vancouver" },
new SelectListItem { Value = "America/Whitehorse", Text = "America/Whitehorse" },
new SelectListItem { Value = "America/Winnipeg", Text = "America/Winnipeg" },
new SelectListItem { Value = "America/Yakutat", Text = "America/Yakutat" },
new SelectListItem { Value = "America/Yellowknife", Text = "America/Yellowknife" },

// Antarctica
new SelectListItem { Value = "Antarctica/Casey", Text = "Antarctica/Casey" },
new SelectListItem { Value = "Antarctica/Davis", Text = "Antarctica/Davis" },
new SelectListItem { Value = "Antarctica/DumontDUrville", Text = "Antarctica/DumontDUrville" },
new SelectListItem { Value = "Antarctica/Macquarie", Text = "Antarctica/Macquarie" },
new SelectListItem { Value = "Antarctica/Mawson", Text = "Antarctica/Mawson" },
new SelectListItem { Value = "Antarctica/Palmer", Text = "Antarctica/Palmer" },
new SelectListItem { Value = "Antarctica/Rothera", Text = "Antarctica/Rothera" },
new SelectListItem { Value = "Antarctica/Syowa", Text = "Antarctica/Syowa" },
new SelectListItem { Value = "Antarctica/Troll", Text = "Antarctica/Troll" },
new SelectListItem { Value = "Antarctica/Vostok", Text = "Antarctica/Vostok" },

// Arctic
new SelectListItem { Value = "Arctic/Longyearbyen", Text = "Arctic/Longyearbyen" },

// Asia
new SelectListItem { Value = "Asia/Aden", Text = "Asia/Aden" },
new SelectListItem { Value = "Asia/Almaty", Text = "Asia/Almaty" },
new SelectListItem { Value = "Asia/Amman", Text = "Asia/Amman" },
new SelectListItem { Value = "Asia/Anadyr", Text = "Asia/Anadyr" },
new SelectListItem { Value = "Asia/Aqtau", Text = "Asia/Aqtau" },
new SelectListItem { Value = "Asia/Aqtobe", Text = "Asia/Aqtobe" },
new SelectListItem { Value = "Asia/Ashgabat", Text = "Asia/Ashgabat" },
new SelectListItem { Value = "Asia/Atyrau", Text = "Asia/Atyrau" },
new SelectListItem { Value = "Asia/Baghdad", Text = "Asia/Baghdad" },
new SelectListItem { Value = "Asia/Bahrain", Text = "Asia/Bahrain" },
new SelectListItem { Value = "Asia/Baku", Text = "Asia/Baku" },
new SelectListItem { Value = "Asia/Bangkok", Text = "Asia/Bangkok" },
new SelectListItem { Value = "Asia/Barnaul", Text = "Asia/Barnaul" },
new SelectListItem { Value = "Asia/Beirut", Text = "Asia/Beirut" },
new SelectListItem { Value = "Asia/Bishkek", Text = "Asia/Bishkek" },
new SelectListItem { Value = "Asia/Brunei", Text = "Asia/Brunei" },
new SelectListItem { Value = "Asia/Chita", Text = "Asia/Chita" },
new SelectListItem { Value = "Asia/Choibalsan", Text = "Asia/Choibalsan" },
new SelectListItem { Value = "Asia/Colombo", Text = "Asia/Colombo" },
new SelectListItem { Value = "Asia/Damascus", Text = "Asia/Damascus" },
new SelectListItem { Value = "Asia/Dhaka", Text = "Asia/Dhaka" },
new SelectListItem { Value = "Asia/Dili", Text = "Asia/Dili" },
new SelectListItem { Value = "Asia/Dubai", Text = "Asia/Dubai" },
new SelectListItem { Value = "Asia/Dushanbe", Text = "Asia/Dushanbe" },
new SelectListItem { Value = "Asia/Famagusta", Text = "Asia/Famagusta" },
new SelectListItem { Value = "Asia/Gaza", Text = "Asia/Gaza" },
new SelectListItem { Value = "Asia/Hebron", Text = "Asia/Hebron" },
new SelectListItem { Value = "Asia/Ho_Chi_Minh", Text = "Asia/Ho_Chi_Minh" },
new SelectListItem { Value = "Asia/Hong_Kong", Text = "Asia/Hong_Kong" },
new SelectListItem { Value = "Asia/Hovd", Text = "Asia/Hovd" },
new SelectListItem { Value = "Asia/Irkutsk", Text = "Asia/Irkutsk" },
new SelectListItem { Value = "Asia/Jakarta", Text = "Asia/Jakarta" },
new SelectListItem { Value = "Asia/Jayapura", Text = "Asia/Jayapura" },
new SelectListItem { Value = "Asia/Jerusalem", Text = "Asia/Jerusalem" },
new SelectListItem { Value = "Asia/Kabul", Text = "Asia/Kabul" },
new SelectListItem { Value = "Asia/Kamchatka", Text = "Asia/Kamchatka" },
new SelectListItem { Value = "Asia/Karachi", Text = "Asia/Karachi" },
new SelectListItem { Value = "Asia/Kathmandu", Text = "Asia/Kathmandu" },
new SelectListItem { Value = "Asia/Khandyga", Text = "Asia/Khandyga" },
new SelectListItem { Value = "Asia/Kolkata", Text = "Asia/Kolkata" },
new SelectListItem { Value = "Asia/Krasnoyarsk", Text = "Asia/Krasnoyarsk" },
new SelectListItem { Value = "Asia/Kuala_Lumpur", Text = "Asia/Kuala_Lumpur" },
new SelectListItem { Value = "Asia/Kuching", Text = "Asia/Kuching" },
new SelectListItem { Value = "Asia/Kuwait", Text = "Asia/Kuwait" },
new SelectListItem { Value = "Asia/Macau", Text = "Asia/Macau" },
new SelectListItem { Value = "Asia/Magadan", Text = "Asia/Magadan" },
new SelectListItem { Value = "Asia/Makassar", Text = "Asia/Makassar" },
new SelectListItem { Value = "Asia/Manila", Text = "Asia/Manila" },
new SelectListItem { Value = "Asia/Muscat", Text = "Asia/Muscat" },
new SelectListItem { Value = "Asia/Nicosia", Text = "Asia/Nicosia" },
new SelectListItem { Value = "Asia/Novokuznetsk", Text = "Asia/Novokuznetsk" },
new SelectListItem { Value = "Asia/Novosibirsk", Text = "Asia/Novosibirsk" },
new SelectListItem { Value = "Asia/Omsk", Text = "Asia/Omsk" },
new SelectListItem { Value = "Asia/Oral", Text = "Asia/Oral" },
new SelectListItem { Value = "Asia/Phnom_Penh", Text = "Asia/Phnom_Penh" },
new SelectListItem { Value = "Asia/Pontianak", Text = "Asia/Pontianak" },
new SelectListItem { Value = "Asia/Pyongyang", Text = "Asia/Pyongyang" },
new SelectListItem { Value = "Asia/Qatar", Text = "Asia/Qatar" },
new SelectListItem { Value = "Asia/Qostanay", Text = "Asia/Qostanay" },
new SelectListItem { Value = "Asia/Qyzylorda", Text = "Asia/Qyzylorda" },
new SelectListItem { Value = "Asia/Riyadh", Text = "Asia/Riyadh" },
new SelectListItem { Value = "Asia/Sakhalin", Text = "Asia/Sakhalin" },
new SelectListItem { Value = "Asia/Samarkand", Text = "Asia/Samarkand" },
new SelectListItem { Value = "Asia/Seoul", Text = "Asia/Seoul" },
new SelectListItem { Value = "Asia/Shanghai", Text = "Asia/Shanghai" },
new SelectListItem { Value = "Asia/Singapore", Text = "Asia/Singapore" },
new SelectListItem { Value = "Asia/Srednekolymsk", Text = "Asia/Srednekolymsk" },
new SelectListItem { Value = "Asia/Taipei", Text = "Asia/Taipei" },
new SelectListItem { Value = "Asia/Tashkent", Text = "Asia/Tashkent" },
new SelectListItem { Value = "Asia/Tbilisi", Text = "Asia/Tbilisi" },
new SelectListItem { Value = "Asia/Tehran", Text = "Asia/Tehran" },
new SelectListItem { Value = "Asia/Thimphu", Text = "Asia/Thimphu" },
new SelectListItem { Value = "Asia/Tokyo", Text = "Asia/Tokyo" },
new SelectListItem { Value = "Asia/Tomsk", Text = "Asia/Tomsk" },
new SelectListItem { Value = "Asia/Ulaanbaatar", Text = "Asia/Ulaanbaatar" },
new SelectListItem { Value = "Asia/Urumqi", Text = "Asia/Urumqi" },
new SelectListItem { Value = "Asia/Ust-Nera", Text = "Asia/Ust-Nera" },
new SelectListItem { Value = "Asia/Vientiane", Text = "Asia/Vientiane" },
new SelectListItem { Value = "Asia/Vladivostok", Text = "Asia/Vladivostok" },
new SelectListItem { Value = "Asia/Yakutsk", Text = "Asia/Yakutsk" },
new SelectListItem { Value = "Asia/Yangon", Text = "Asia/Yangon" },
new SelectListItem { Value = "Asia/Yekaterinburg", Text = "Asia/Yekaterinburg" },
new SelectListItem { Value = "Asia/Yerevan", Text = "Asia/Yerevan" },

// Atlantic
new SelectListItem { Value = "Atlantic/Azores", Text = "Atlantic/Azores" },
new SelectListItem { Value = "Atlantic/Bermuda", Text = "Atlantic/Bermuda" },
new SelectListItem { Value = "Atlantic/Canary", Text = "Atlantic/Canary" },
new SelectListItem { Value = "Atlantic/Cape_Verde", Text = "Atlantic/Cape_Verde" },
new SelectListItem { Value = "Atlantic/Faroe", Text = "Atlantic/Faroe" },
new SelectListItem { Value = "Atlantic/Madeira", Text = "Atlantic/Madeira" },
new SelectListItem { Value = "Atlantic/Reykjavik", Text = "Atlantic/Reykjavik" },
new SelectListItem { Value = "Atlantic/South_Georgia", Text = "Atlantic/South_Georgia" },
new SelectListItem { Value = "Atlantic/St_Helena", Text = "Atlantic/St_Helena" },
new SelectListItem { Value = "Atlantic/Stanley", Text = "Atlantic/Stanley" },

// Australia
new SelectListItem { Value = "Australia/Adelaide", Text = "Australia/Adelaide" },
new SelectListItem { Value = "Australia/Brisbane", Text = "Australia/Brisbane" },
new SelectListItem { Value = "Australia/Broken_Hill", Text = "Australia/Broken_Hill" },
new SelectListItem { Value = "Australia/Currie", Text = "Australia/Currie" },
new SelectListItem { Value = "Australia/Darwin", Text = "Australia/Darwin" },
new SelectListItem { Value = "Australia/Eucla", Text = "Australia/Eucla" },
new SelectListItem { Value = "Australia/Hobart", Text = "Australia/Hobart" },
new SelectListItem { Value = "Australia/Lindeman", Text = "Australia/Lindeman" },
new SelectListItem { Value = "Australia/Lord_Howe", Text = "Australia/Lord_Howe" },
new SelectListItem { Value = "Australia/Melbourne", Text = "Australia/Melbourne" },
new SelectListItem { Value = "Australia/Perth", Text = "Australia/Perth" },
new SelectListItem { Value = "Australia/Sydney", Text = "Australia/Sydney" },

// Europe
new SelectListItem { Value = "Europe/Amsterdam", Text = "Europe/Amsterdam" },
new SelectListItem { Value = "Europe/Andorra", Text = "Europe/Andorra" },
new SelectListItem { Value = "Europe/Astrakhan", Text = "Europe/Astrakhan" },
new SelectListItem { Value = "Europe/Athens", Text = "Europe/Athens" },
new SelectListItem { Value = "Europe/Podgorica", Text = "Europe/Podgorica" },
new SelectListItem { Value = "Europe/Prague", Text = "Europe/Prague" },
new SelectListItem { Value = "Europe/Riga", Text = "Europe/Riga" },
new SelectListItem { Value = "Europe/Rome", Text = "Europe/Rome" },
new SelectListItem { Value = "Europe/Samara", Text = "Europe/Samara" },
new SelectListItem { Value = "Europe/San_Marino", Text = "Europe/San_Marino" },
new SelectListItem { Value = "Europe/Sarajevo", Text = "Europe/Sarajevo" },
new SelectListItem { Value = "Europe/Saratov", Text = "Europe/Saratov" },
new SelectListItem { Value = "Europe/Simferopol", Text = "Europe/Simferopol" },
new SelectListItem { Value = "Europe/Skopje", Text = "Europe/Skopje" },
new SelectListItem { Value = "Europe/Sofia", Text = "Europe/Sofia" },
new SelectListItem { Value = "Europe/Stockholm", Text = "Europe/Stockholm" },
new SelectListItem { Value = "Europe/Tallinn", Text = "Europe/Tallinn" },
new SelectListItem { Value = "Europe/Tirane", Text = "Europe/Tirane" },
new SelectListItem { Value = "Europe/Ulyanovsk", Text = "Europe/Ulyanovsk" },
new SelectListItem { Value = "Europe/Uzhgorod", Text = "Europe/Uzhgorod" },
new SelectListItem { Value = "Europe/Vaduz", Text = "Europe/Vaduz" },
new SelectListItem { Value = "Europe/Vatican", Text = "Europe/Vatican" },
new SelectListItem { Value = "Europe/Vienna", Text = "Europe/Vienna" },
new SelectListItem { Value = "Europe/Vilnius", Text = "Europe/Vilnius" },
new SelectListItem { Value = "Europe/Volgograd", Text = "Europe/Volgograd" },
new SelectListItem { Value = "Europe/Warsaw", Text = "Europe/Warsaw" },
new SelectListItem { Value = "Europe/Zagreb", Text = "Europe/Zagreb" },
new SelectListItem { Value = "Europe/Zaporozhye", Text = "Europe/Zaporozhye" },
new SelectListItem { Value = "Europe/Zurich", Text = "Europe/Zurich" },

// Indian
new SelectListItem { Value = "Indian/Antananarivo", Text = "Indian/Antananarivo" },
new SelectListItem { Value = "Indian/Chagos", Text = "Indian/Chagos" },
new SelectListItem { Value = "Indian/Christmas", Text = "Indian/Christmas" },
new SelectListItem { Value = "Indian/Cocos", Text = "Indian/Cocos" },
new SelectListItem { Value = "Indian/Comoro", Text = "Indian/Comoro" },
new SelectListItem { Value = "Indian/Kerguelen", Text = "Indian/Kerguelen" },
new SelectListItem { Value = "Indian/Mahe", Text = "Indian/Mahe" },
new SelectListItem { Value = "Indian/Maldives", Text = "Indian/Maldives" },
new SelectListItem { Value = "Indian/Mauritius", Text = "Indian/Mauritius" },
new SelectListItem { Value = "Indian/Mayotte", Text = "Indian/Mayotte" },
new SelectListItem { Value = "Indian/Reunion", Text = "Indian/Reunion" },

// Pacific
new SelectListItem { Value = "Pacific/Apia", Text = "Pacific/Apia" },
new SelectListItem { Value = "Pacific/Auckland", Text = "Pacific/Auckland" },
new SelectListItem { Value = "Pacific/Bougainville", Text = "Pacific/Bougainville" },
new SelectListItem { Value = "Pacific/Chatham", Text = "Pacific/Chatham" },
new SelectListItem { Value = "Pacific/Chuuk", Text = "Pacific/Chuuk" },
new SelectListItem { Value = "Pacific/Easter", Text = "Pacific/Easter" },
new SelectListItem { Value = "Pacific/Efate", Text = "Pacific/Efate" },
new SelectListItem { Value = "Pacific/Enderbury", Text = "Pacific/Enderbury" },
new SelectListItem { Value = "Pacific/Fakaofo", Text = "Pacific/Fakaofo" },
new SelectListItem { Value = "Pacific/Fiji", Text = "Pacific/Fiji" },
new SelectListItem { Value = "Pacific/Funafuti", Text = "Pacific/Funafuti" },
new SelectListItem { Value = "Pacific/Galapagos", Text = "Pacific/Galapagos" },
new SelectListItem { Value = "Pacific/Gambier", Text = "Pacific/Gambier" },
new SelectListItem { Value = "Pacific/Guadalcanal", Text = "Pacific/Guadalcanal" },
new SelectListItem { Value = "Pacific/Guam", Text = "Pacific/Guam" },
new SelectListItem { Value = "Pacific/Honolulu", Text = "Pacific/Honolulu" },
new SelectListItem { Value = "Pacific/Kiritimati", Text = "Pacific/Kiritimati" },
new SelectListItem { Value = "Pacific/Kosrae", Text = "Pacific/Kosrae" },
new SelectListItem { Value = "Pacific/Kwajalein", Text = "Pacific/Kwajalein" },
new SelectListItem { Value = "Pacific/Majuro", Text = "Pacific/Majuro" },
new SelectListItem { Value = "Pacific/Marquesas", Text = "Pacific/Marquesas" },
new SelectListItem { Value = "Pacific/Midway", Text = "Pacific/Midway" },
new SelectListItem { Value = "Pacific/Nauru", Text = "Pacific/Nauru" },
new SelectListItem { Value = "Pacific/Niue", Text = "Pacific/Niue" },
new SelectListItem { Value = "Pacific/Norfolk", Text = "Pacific/Norfolk" },
new SelectListItem { Value = "Pacific/Noumea", Text = "Pacific/Noumea" },
new SelectListItem { Value = "Pacific/Pago_Pago", Text = "Pacific/Pago_Pago" },
new SelectListItem { Value = "Pacific/Palau", Text = "Pacific/Palau" },
new SelectListItem { Value = "Pacific/Pitcairn", Text = "Pacific/Pitcairn" },
new SelectListItem { Value = "Pacific/Pohnpei", Text = "Pacific/Pohnpei" },
new SelectListItem { Value = "Pacific/Port_Moresby", Text = "Pacific/Port_Moresby" },
new SelectListItem { Value = "Pacific/Rarotonga", Text = "Pacific/Rarotonga" },
new SelectListItem { Value = "Pacific/Saipan", Text = "Pacific/Saipan" },
new SelectListItem { Value = "Pacific/Tahiti", Text = "Pacific/Tahiti" },
new SelectListItem { Value = "Pacific/Tarawa", Text = "Pacific/Tarawa" },
new SelectListItem { Value = "Pacific/Tongatapu", Text = "Pacific/Tongatapu" },
new SelectListItem { Value = "Pacific/Wake", Text = "Pacific/Wake" },
new SelectListItem { Value = "Pacific/Wallis", Text = "Pacific/Wallis" },
            };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //renewing the API call and returning to my page
            OnGet();

            if (!string.IsNullOrEmpty(SelectedTimeZone))
            {
                var response = await _httpClient.GetStringAsync($"https://timeapi.io/api/TimeZone/zone?timeZone={SelectedTimeZone}");

                var data = JObject.Parse(response);


              var rawTime = data["currentLocalTime"].Value<string>();
              

                DateTime dt = DateTime.Parse(rawTime);

                string timezone = data["timeZone"].Value<string>();
                string area = timezone.Split('/').Last();

                ApiResponseName = area;
                

                ApiResponseTime = dt.ToString("h:mm tt");
                ApiDayTime = dt.ToString("MM/dd/yyyy");
                
            }

            return Page();
        }
    }
}