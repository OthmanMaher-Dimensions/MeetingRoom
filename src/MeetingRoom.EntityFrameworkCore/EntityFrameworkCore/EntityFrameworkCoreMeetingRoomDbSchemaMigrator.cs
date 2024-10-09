using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeetingRoom.Data;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.EntityFrameworkCore;

public class EntityFrameworkCoreMeetingRoomDbSchemaMigrator
    : IMeetingRoomDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMeetingRoomDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the MeetingRoomDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MeetingRoomDbContext>()
            .Database
            .MigrateAsync();
    }
}
