using Mabit.Models.Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using Mabit.Models.Model;
using Mabit.Services.Helper;
using System.Threading.Tasks;

namespace Mabit.Services.UserService
{
    public class UserService
    {
        private string culture = System.Globalization.CultureInfo.CurrentCulture.Name;
        public bool Register(Register model)
        {
            return HttpHelper.Post<Register>("api/Users/Register", culture, model).IsCompleted;
        }
    }
}
