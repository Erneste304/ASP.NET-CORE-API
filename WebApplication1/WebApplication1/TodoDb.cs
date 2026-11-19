namespace WebApplication1;

using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
    public DbSet<Movie> Movies => Set<Movie>();
}