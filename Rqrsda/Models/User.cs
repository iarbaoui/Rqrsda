using Microsoft.AspNet.Identity.EntityFramework;

namespace Rqrsda.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}