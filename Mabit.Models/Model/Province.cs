using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Province:BaseModel
    {
        public List<City> Cities { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }

    }
}
