using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.Common
{
    public class FileUploadModel
    {
        public string base64 { get; set; }
        public string fileName { get; set; }
        public string mimeType { get; set; }
    }
    public class FileUploadResult
    {
        public int id { get; set; }
    }
}
