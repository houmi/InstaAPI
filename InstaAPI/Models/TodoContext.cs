using Microsoft.EntityFrameworkCore;

namespace InstaAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> todoItems { get; set; }
    }
}
