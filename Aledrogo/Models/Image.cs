namespace Aledrogo.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public byte[] ImageFile { get; set; }
    }
}
