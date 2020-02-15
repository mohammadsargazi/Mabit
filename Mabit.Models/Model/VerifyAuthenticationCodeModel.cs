using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class VerifyAuthenticationCodeModel
    {
        public string Code { get; set; }
        public string Phone { get; set; }
    }
}
