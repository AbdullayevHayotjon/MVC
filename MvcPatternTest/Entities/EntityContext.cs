using Microsoft.EntityFrameworkCore;
using MvcPatternTest.Models;

namespace MvcPatternTest.Entities
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
    }
}
