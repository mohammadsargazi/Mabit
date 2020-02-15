using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.Common
{

    public class TopRoom : BaseModel
    {
        private string _picUrl;
        public string mainPictureApiUrl { get; set; }
        public string middleWeekPrice { get; set; }
        public string holydayPrice { get; set; }
        public string peakDayPrice { get; set; }
        public string extraPersonPrice { get; set; }
        public City City { get; set; }
        public Province Province { get; set; }
        public Country Country { get; set; }
        public ownerFullname ownerFullname { get; set; }
        public int averageRate { get; set; }
        public List<Option> Options { get; set; }
        public string buildingArea { get; set; }
        public string landArea { get; set; }
        public string roomCount { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public List<ApiUrl> pictures { get; set; }
        
    }
    #region RelateModel
   
    public class BaseRelateModel
    {
        public int id { get; set; }
        public string title { get; set; }
    }
    public class City : BaseRelateModel { }
    public class Province : BaseRelateModel { }
    public class Country : BaseRelateModel { }
    public class Option
    {
        public BaseRelateModel title { get; set; }
        public bool has { get; set; }
    }
    public class ownerFullname : BaseRelateModel { }
    public class ApiUrl
    {
        private string _picUrl;
        public string apiUrl { get { return _picUrl; } set { _picUrl = "http://185.173.105.237:81" + value; } }
    }

    #endregion

}
