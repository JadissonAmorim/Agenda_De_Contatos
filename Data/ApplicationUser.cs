using Microsoft.AspNetCore.Identity;

namespace AgendaContatos.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
    }
}
