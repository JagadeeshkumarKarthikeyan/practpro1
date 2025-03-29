using Microsoft.EntityFrameworkCore;

namespace practpro1.model
{
    
    public class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CDC2-L-G04GES0;Initial Catalog=db_review;Integrated security=true;trustServerCertificate=true");
        }
       public DbSet<getmodel> review {  get; set; }
    }
}
