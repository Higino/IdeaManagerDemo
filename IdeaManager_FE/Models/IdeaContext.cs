using Microsoft.EntityFrameworkCore;

namespace IdeaManager_FE.Models
{
    public class IdeaContext : DbContext
    {
        public IdeaContext(DbContextOptions<IdeaContext> options)
            : base(options)
        {
        }

        public DbSet<Idea> IdeaItems { get; set; }

    }
}