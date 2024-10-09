using Volo.Abp.Modularity;

namespace MeetingRoom;

[DependsOn(
    typeof(MeetingRoomApplicationModule),
    typeof(MeetingRoomDomainTestModule)
)]
public class MeetingRoomApplicationTestModule : AbpModule
{

}
