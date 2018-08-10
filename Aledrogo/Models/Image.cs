namespace Aledrogo.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public byte[] ImageFile { get; set; }
    }
}
