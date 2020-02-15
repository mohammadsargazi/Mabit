using Mabit.Models.Model.Common;
using Mabit.Services.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Services.CommonService
{
    public class CommonService
    {
        #region Fields
        private readonly string topCitiesUrl = "api/Common/TopCities";
        private readonly string topRoomsUrl = "api/Rooms/TopRooms";
        private string culture = System.Globalization.CultureInfo.CurrentCulture.Name;
        #endregion

        #region Method
        public List<TopCity> GetTopCities()
        {
            return HttpHelper.GetAll<TopCity>(topCitiesUrl, culture).Result;
        }
        public List<TopRoom> GetTopRooms()
        {
             return HttpHelper.GetAllTopRom<TopRoom>(topRoomsUrl, culture).Result;
        }

        public List<Country> GetCountries()
        {
            return HttpHelper.GetAll<Country>("api/Common/Countries", culture).Result;
        }

        public List<Province> GetProvince(int countryId)
        {
            return HttpHelper.GetAll<Province>("api/Common/Provinces" + "/" + countryId, culture).Result;
        }

        public List<Countries> Countries()
        {
            return HttpHelper.GetAll<Countries>("api/Common/Countries", culture).Result;
        }

        public object GetCity(int provinceId)
        {
            return HttpHelper.GetAll<Province>("api/Common/Cities/" + provinceId, culture).Result;
        }
        #endregion
    }
}
