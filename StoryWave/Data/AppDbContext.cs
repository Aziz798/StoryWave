using Microsoft.EntityFrameworkCore;

namespace StoryWave.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options)
    {
        
    }
}
