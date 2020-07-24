using LazZiya.ExpressLocalization.Messages;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Views.validations.Room
{
    public class StepTwoValidationViewModel
    {
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public IList<IFormFile> Files { get; set; }
    }
}
