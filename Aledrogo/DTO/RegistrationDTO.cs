using System.ComponentModel.DataAnnotations;

namespace Aledrogo.DTO
{
    public class RegistrationDTO
    {
        [EmailAddress]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
