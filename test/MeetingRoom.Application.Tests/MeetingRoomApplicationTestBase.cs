using Volo.Abp.Modularity;

namespace MeetingRoom;

public abstract class MeetingRoomApplicationTestBase<TStartupModule> : MeetingRoomTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
