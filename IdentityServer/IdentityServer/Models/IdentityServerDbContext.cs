

using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Models
{
    public class IdentityServerDbContext : DbContext
    {
        public IdentityServerDbContext(DbContextOptions<IdentityServerDbContext> options)
          : base(options)
        {
        }
    }
}
