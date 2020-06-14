using Mabit.Models.Model.HotelModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class AddCategoryHotelViewModel
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int DoubleBed { get; set; }
        public int Bed { get; set; }
        public List<int> HotelCategoryOptionsId { get; set; }
        public List<int> PicturesId { get; set; }
    }
    public static class ExtentionModel
    {
        public static AddHotelCategoryModel ToModel(this AddCategoryHotelViewModel model)
        {
            if (model == null)
                return null;
            return new AddHotelCategoryModel
            {
                Area = model.Area,
                Bed = model.Bed,
                DoubleBed = model.DoubleBed,
                HotelCategoryOptionsId = model.HotelCategoryOptionsId,
                Title = model.Name,
                PicturesId = model.PicturesId
            };
        }
    }
}
