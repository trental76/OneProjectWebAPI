using OneProjectWebAPI.BL.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.IO;

namespace OneProjectWebAPI.Persistance;

public class LiteDBContext : DbContext 
{
    public LiteDBContext(IOptions<DBOptions> options)
    {
        ArgumentNullException.ThrowIfNull(options);

        var folder = Environment.SpecialFolder.LocalApplicationData;
        var dbDirectory = Path.Combine(Environment.GetFolderPath(folder), options.Value.Directory);
        Directory.CreateDirectory(dbDirectory);
        DBPath = Path.Combine(dbDirectory, options.Value.DBName);
    }

    public string DBPath { get; }

    public DbSet<UserModel> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the context to use LiteDB
        optionsBuilder.UseSqlite($"Data Source={DBPath}");
    }
}
