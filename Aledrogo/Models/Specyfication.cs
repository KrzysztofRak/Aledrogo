using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class Specyfication
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<SpecyficationValue> SpecyficationValues { get; set; }
        public string Title { get; set; }
    }
}
