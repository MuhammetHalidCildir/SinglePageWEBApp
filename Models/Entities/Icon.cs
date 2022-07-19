using System.ComponentModel.DataAnnotations;

namespace SinglePageWebApp.Models.Entities
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string TagId { get; set; }
        public string TagClass { get; set; }
        public string Paragraph { get; set; }
        public string IconType { get; set; }
        public string Url { get; set; }
        public virtual Section Section { get; set; }
    }
}