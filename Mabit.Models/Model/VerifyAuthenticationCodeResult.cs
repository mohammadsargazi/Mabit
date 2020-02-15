using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class VerifyAuthenticationCodeResult
    {
        public bool Verfied { get; set; }
        public bool HasProfile { get; set; }
        public string UserIdentity { get; set; }
    }
}
