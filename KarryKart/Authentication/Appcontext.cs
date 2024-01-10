using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace KarryKart.Authentication
{
    public class Appcontext : IdentityDbContext<IdentityUser>
    {
        public Appcontext(DbContextOptions<Appcontext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
    
}
