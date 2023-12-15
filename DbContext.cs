namespace WebApplication1JUlio
{
    public class DbContext
    {
        private DbContextOptions options;

        public DbContext(DbContextOptions options)
        {
            this.options = options;
        }
    }
}