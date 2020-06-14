using Mabit.Models.Model;
using Mabit.Models.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class HostingViewModel
    {
        public List<BaseRelateModel> Options { get; set; }
        public List<BaseRelateModel> TextureOptions { get; set; }
        public List<BaseRelateModel> Structures { get; set; }
        public List<BaseRelateModel> RoomTypes { get; set; }
        public List<BaseRelateModel> LocationOptions { get; set; }
        public List<BaseRelateModel> LocationTypes { get; set; }
        public List<BaseRelateModel> CustomRules { get; set; }
        public List<HotelType> HotelTypes { get; set; }
        public List<CategoryOption> CategoryOptions { get; set; }
        public List<BaseRelateModel> HotelCategories { get; set; }
        public List<Mabit.Models.Model.Common.Country> Countries  { get; set; }
    }
}
