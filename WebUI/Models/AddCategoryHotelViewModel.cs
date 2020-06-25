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
        public int[] HotelCategoryOptionsId { get; set; }
        public int[] PicturesId { get; set; }
    }
    public static class ExtentionModel
    {
        public static AddHotelCategoryModel ToModel(this AddCategoryHotelViewModel model)
        {
            if (model == null)
                return null;
            try
            {
                return new AddHotelCategoryModel
                {
                    Area = model.Area,
                    Bed = model.Bed,
                    DoubleBed = model.DoubleBed,
                    HotelCategoryOptionsId = model.HotelCategoryOptionsId.ToList(),
                    Title = model.Name,
                    PicturesId = model.PicturesId?.ToList()
                };
            }
            catch(Exception ex)
            {
                return new AddHotelCategoryModel();
            }
        }
    }
}
