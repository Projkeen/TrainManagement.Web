using Microsoft.EntityFrameworkCore;
using TrainManagement.Web.Models;
namespace TrainManagement.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<TrainModel> Trains { get; set; }

    }
}
