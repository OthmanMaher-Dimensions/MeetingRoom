using Volo.Abp.Modularity;

namespace MeetingRoom;

/* Inherit from this class for your domain layer tests. */
public abstract class MeetingRoomDomainTestBase<TStartupModule> : MeetingRoomTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
