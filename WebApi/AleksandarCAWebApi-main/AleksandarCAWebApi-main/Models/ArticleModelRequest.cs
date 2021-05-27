using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Models
{
    public class ArticleModelRequest
    {
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public string Type { get; set; }
    }
}
