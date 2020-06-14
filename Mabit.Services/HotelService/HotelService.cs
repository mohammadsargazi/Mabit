using Mabit.Models.Model.HotelModel;
using Mabit.Services.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Services.HotelService
{
    public class HotelService
    {
        private readonly string url = "api/Hotel";
        private string culture = System.Globalization.CultureInfo.CurrentCulture.Name;

        public AddRoomResultModel AddHotelCategory(AddHotelCategoryModel model, string token)
        {
            return HttpHelper.Post<AddRoomResultModel, AddHotelCategoryModel>("api/Hotel/AddHotelCategory", culture, model, token).Result;
        }
    }
}
