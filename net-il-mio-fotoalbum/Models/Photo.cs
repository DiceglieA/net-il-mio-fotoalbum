using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace net_il_mio_fotoalbum.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [StringLength(40, ErrorMessage = "Il titolo non puo avere piu di 40 caratteri")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obbligatorio")]
        [Column(TypeName = "text")]
  
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obbligatorio")]
        public string Pic { get; set; } = string.Empty;

        public bool IsVisible { get; set; }


        public List<Category>? Categories { get; set; }
    }
}
