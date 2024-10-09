using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MeetingRoom.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MeetingRoomDbContextFactory : IDesignTimeDbContextFactory<MeetingRoomDbContext>
{
    public MeetingRoomDbContext CreateDbContext(string[] args)
    {
        MeetingRoomEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MeetingRoomDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new MeetingRoomDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MeetingRoom.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
