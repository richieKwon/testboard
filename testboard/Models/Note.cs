using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testboard.Models
{
    public class Note
    {
        /// <summary>
        /// contents table columns 
        /// </summary>
        [Key]
        public int NoteNo { get; set; }
        
        [Required]
        public string NoteTitle { get; set; }
        
        [Required]
        public string NoteContents { get; set; }
        
        [Required]
        public int UserNo { get; set; }
        
        [ForeignKey("UserNo")]
        public virtual User User { get; set; } //access User class and join
    }
}