using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SinglePageWebApp.Models.Entities
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public string TagId { get; set; }
        public string TagClass { get; set; }
        public string SectionType { get; set; }
        public string Header { get; set; }
        public string Paragraph { get; set; }
        public virtual ICollection<Icon> Icons { get; set; }
    }
}