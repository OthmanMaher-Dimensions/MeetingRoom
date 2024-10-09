using System.Threading.Tasks;

namespace MeetingRoom.Data;

public interface IMeetingRoomDbSchemaMigrator
{
    Task MigrateAsync();
}
