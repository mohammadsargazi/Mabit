﻿using Mabit.Models.Model.Common;
using Mabit.Services.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
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
        public List<HotelType> GetHotelType()
        {
            return HttpHelper.GetAll<HotelType>("api/Common/HotelType", culture).Result;
        }
        public List<BaseRelateModel> GetHotelCategory()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/HotelCategory", culture).Result;
        }
        public List<CategoryOption> GetCategoryOption()
        {
            return HttpHelper.GetAll<CategoryOption>("api/Common/CategoryOption", culture).Result;
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

        public List<BaseRelateModel> Options()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/Options",culture).Result;
        }
        public List<BaseRelateModel> TextureOptions()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/TextureOptions", culture).Result;
        }
        public List<BaseRelateModel> Structures()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/Structures", culture).Result;
        }
        public List<BaseRelateModel> RoomTypes()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/RoomTypes", culture).Result;
        }
        public List<BaseRelateModel> LocationOptions()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/LocationOptions", culture).Result;
        }
        public List<BaseRelateModel> LocationTypes()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/LocationTypes", culture).Result;
        }
        public List<BaseRelateModel> CustomRules()
        {
            return HttpHelper.GetAll<BaseRelateModel>("api/Common/CustomRules", culture).Result;
        }
        public int Upload(IList<IFormFile> files)
        {
            return HttpHelper.Upload("api/Files/Upload", culture, files).Result;
        }
        public int UploadBase64(FileUploadModel file)
        {
            return HttpHelper.UploadBase64("api/Files/UploadBase64", file).Result;
        }
        #endregion
    }
}
