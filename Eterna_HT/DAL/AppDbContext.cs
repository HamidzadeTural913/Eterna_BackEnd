using Eterna_HT.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna_HT.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Box> Boxs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<SocialContact> SocialContacts { get; set; }
    }
}
