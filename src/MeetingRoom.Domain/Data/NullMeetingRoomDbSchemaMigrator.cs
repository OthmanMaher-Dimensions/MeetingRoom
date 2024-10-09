using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Data;

/* This is used if database provider does't define
 * IMeetingRoomDbSchemaMigrator implementation.
 */
public class NullMeetingRoomDbSchemaMigrator : IMeetingRoomDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
