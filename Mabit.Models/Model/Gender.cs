using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Gender:BaseModel
    {
        public List<User> Users { get; set; }
    }
}
