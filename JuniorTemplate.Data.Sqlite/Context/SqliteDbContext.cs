using Microsoft.EntityFrameworkCore;
using NeerCore.Data.EntityFramework.Abstractions;
using NeerCore.Data.EntityFramework.Extensions;

namespace JuniorTemplate.Data.Context;

public class SqliteDbContext : DbContext, IDatabaseContext
{
    public SqliteDbContext(DbContextOptions options) : base(options)
    {
        // TODO: Remove for your project or be the most careful with this!!! :)
        Database.EnsureCreated();
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurations();
        builder.ApplyDataSeeders();
    }
}