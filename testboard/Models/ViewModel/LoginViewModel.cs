using System.ComponentModel.DataAnnotations;

namespace testboard.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "NEED USERID")]
        public string UserId { get; set; }
        
        [Required(ErrorMessage = "Need password")]
        public string UserPassword { get; set; }
        
    }
}