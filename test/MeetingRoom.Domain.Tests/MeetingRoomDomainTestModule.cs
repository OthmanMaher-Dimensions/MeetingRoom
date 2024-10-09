using Volo.Abp.Modularity;

namespace MeetingRoom;

[DependsOn(
    typeof(MeetingRoomDomainModule),
    typeof(MeetingRoomTestBaseModule)
)]
public class MeetingRoomDomainTestModule : AbpModule
{

}
