using Mabit.Models.Model.HotelModel;
using Mabit.Services.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Services.HotelService
{
    public class HotelService
    {
        private string culture = System.Globalization.CultureInfo.CurrentCulture.Name;

        public int AddHotel(AddHotelModel model,string token)
        {
            return HttpHelper.Post< AddHotelModel>("api/Hotel/AddHotel", model, token).Result;
        }

        public AddRoomResultModel AddHotelCategory(AddHotelCategoryModel model, string token)
        {
            return HttpHelper.Post<AddRoomResultModel, AddHotelCategoryModel>("api/Hotel/AddHotelCategory", culture, model, token).Result;
        }
        public AddHotelRoomResultModel AddHotelRoom(AddHotelRoomModel model ,string token)
        {
            return HttpHelper.Post<AddHotelRoomResultModel, AddHotelRoomModel > ("api/Hotel/AddHotelRoom", culture, model, token).Result;
        }
    }
}
