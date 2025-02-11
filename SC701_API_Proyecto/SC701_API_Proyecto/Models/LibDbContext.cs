using Microsoft.EntityFrameworkCore;

namespace SC701_API_Proyecto.Models
{
    public class LibDbContext : DbContext
    {
        public LibDbContext(DbContextOptions<LibDbContext> options) : base(options)
        {

        }


    }
}
