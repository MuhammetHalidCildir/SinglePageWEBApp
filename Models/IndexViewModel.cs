using SinglePageWebApp.Models.Entities;
using System.Collections.Generic;

namespace SinglePageWebApp.Models
{
    public class IndexViewModel
    {
        public string PageTitle { get; set; }
        public string SubTitle { get; set; }
        public List<Section> Sections { get; set; }
    }
}