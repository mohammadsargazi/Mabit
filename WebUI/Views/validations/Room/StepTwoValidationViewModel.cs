using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Views.validations.Room
{
    public class StepTwoValidationViewModel
    {
        public IList<IFormFile> Files { get; set; }
    }
}
