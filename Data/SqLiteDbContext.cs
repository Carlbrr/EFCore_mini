namespace EFCoreProject_itm8prep.Data;
using EFCoreProject_itm8prep.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

//Following tutorial from: https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
public class SqLiteDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public string DbPath { get; private set; }

    
    public SqLiteDbContext()
    {
        //Storing runtime-generated files (like a database) alongside source code can make the project directory messy and less maintainable.
        //To avoid this, we can use the special folder for storing application data.
        //Also, permissions might be an issue when trying to write to the project directory.
        const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "test.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=itm8prep.db");
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    //public List<Post> Posts { get; } = new(); this just ensures that the list is never null. just empty if no posts.
}