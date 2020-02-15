using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Auth
{
    public class RequestTokenResult
    {
        public User User { get; set; }
        public string Token { get; set; }
     
    }
    public class User
    {
        private string _picUrl;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string profileImageUrl { get { return _picUrl; } set { _picUrl = "http://185.173.105.237:81" + value; } }
       
    }
}
