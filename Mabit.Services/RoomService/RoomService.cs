﻿using Mabit.Models.Model;
using Mabit.Models.Model.Common;
using Mabit.Models.Model.RoomModel;
using Mabit.Services.Helper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Mabit.Services.RoomService
{
    public class RoomService
    {
        private readonly string url = "api/Rooms";
        private string culture = System.Globalization.CultureInfo.CurrentCulture.Name;
        #region CRUD
        public List<Room> GetAll()
        {
            return HttpHelper.GetAll<Room>(url).Result;
        }
        public TopRoom Get(int id)
        {
            return HttpHelper.Get<TopRoom>(url + "/" + id).Result;
        }
        public bool Post(Room model)
        {
            return HttpHelper.Post(url, culture, model).IsCompleted;
        }
        public bool Put(Room model)
        {
            return HttpHelper.Put(url + model.id, model).IsCompleted;
        }
        public bool Delete(int id)
        {
            return HttpHelper.Delete(url + id).IsCompleted;
        }
        public AddRoomResultModel AddRoom(AddRoomModel model, string token)
        {
            return HttpHelper.Post<AddRoomResultModel, AddRoomModel>("api/Rooms/AddRoom", culture, model, token).Result;
        }
        public List<TopRoom> MyRooms(string token)
        {
            return HttpHelper.GetAllWithPost<TopRoom>("api/Rooms/MyRooms", culture, token).Result;
        }
        #endregion

        #region SearchRoom
        public List<TopRoom> GetReservationRooms(ReservationRoomModel model)
        {
            return HttpHelper.GetAll<TopRoom, ReservationRoomModel>("api/Rooms/GetReservationRooms", model, culture).Result;
        }
        public SearchRoomResultModel GetReservationRoom(ReservationRoomModel model)
        {
            return HttpHelper.GetReservationRooms<SearchRoomResultModel, ReservationRoomModel>("api/Rooms/GetReservationRooms", model, culture).Result;
        }
        public List<TopRoom> SearchRoom(SearchRoomModel model)
        {

            return HttpHelper.GetAll<TopRoom, SearchRoomModel>("api/Rooms/GetRooms", model, culture).Result;
        }
        #endregion
    }
}
