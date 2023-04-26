using System.ComponentModel.DataAnnotations;

namespace net_il_mio_fotoalbum.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [StringLength(50, ErrorMessage = "Il nome non puo avere piu di 40 caratteri")]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Photo>? Photos { get; set; }
    }
}
