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
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string UserId { get; set; }
        
        [Required]
        public string MyProperty { get; set; }
        
        [Required]
        public string UserPassword { get; set; }
    }
}