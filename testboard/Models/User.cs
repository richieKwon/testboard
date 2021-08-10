using System.ComponentModel.DataAnnotations;

namespace testboard.Models
{
    public class User
    {
        /// <summary>
        /// user table columns 
        /// </summary>
        [Key] //Primary key
        public int UserNo { get; set; }
        
        [Required(ErrorMessage = "UserName is required :)")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "UserID! required!")]
        public string UserId { get; set; }
        
        [Required(ErrorMessage = "Omit!")]
        public string MyProperty { get; set; }
        
        [Required(ErrorMessage = "Password is mandatory!")]
        public string UserPassword { get; set; }
    }
}  