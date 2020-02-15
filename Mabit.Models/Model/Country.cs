using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Country:BaseModel
    {
        public List<Province> Provinces { get; set; }
    }
}
