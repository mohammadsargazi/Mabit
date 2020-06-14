using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.HotelModel
{
   public class AddHotelCategoryModel
    {
        public string Title { get; set; }
        public int Area { get; set; }
        public int DoubleBed { get; set; }
        public int Bed { get; set; }
        public List<int> HotelCategoryOptionsId { get; set; }
        public List<int> PicturesId { get; set; }
    }
}
