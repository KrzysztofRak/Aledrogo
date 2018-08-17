using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public string ImagePath { get; set; }
    }
}
