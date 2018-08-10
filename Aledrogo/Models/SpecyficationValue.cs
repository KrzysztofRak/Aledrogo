using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class SpecyficationValue
    {
        public int Id { get; set; }
        public int SpecyficationId { get; set; }
        public Specyfication Specyfication { get; set; }
        public ICollection<SpecyficationValueProduct> SpecyficationValueProducts { get; set; }
        public string Value { get; set; }
    }
}
