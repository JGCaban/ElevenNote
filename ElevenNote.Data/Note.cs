using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]       //returns unique note number
        public int NoteId { get; set; }

        [Required]      //ensures the user does not a enter a null value
        public Guid OwnerId { get; set; }       //Guid = Globally Unique IDentifier, close to inmpossible to replicate. 

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Resource { get; set; }

        [Required]
        public string Contact { get; set; }

        [DefaultValue(false)]
        public bool IsStarred { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
