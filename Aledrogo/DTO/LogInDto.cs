using System.ComponentModel.DataAnnotations;

namespace Aledrogo.DTO
{
    public class LogInDTO
    {
        [EmailAddress]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool isPersistent { get; set; }
    }
}
