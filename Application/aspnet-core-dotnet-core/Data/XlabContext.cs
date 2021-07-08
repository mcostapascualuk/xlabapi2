using Microsoft.EntityFrameworkCore;
using xlabapi.Model;

namespace xlabapi.Data
{
    public class XlabContext : DbContext
    {
        public XlabContext(DbContextOptions<XlabContext> options) : base(options)
        {
        }

        public DbSet<Leedsbeerquest> Leedsbeerquests { get; set; }
    }
}
