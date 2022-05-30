using System.ComponentModel.DataAnnotations;

namespace AgendaContatos.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Número")]
        public string Number { get; set; }
        public string? User { get; set; } = null;
    }
}
