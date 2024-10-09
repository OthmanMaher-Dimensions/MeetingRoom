using MeetingRoom.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MeetingRoom.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MeetingRoomEntityFrameworkCoreModule),
    typeof(MeetingRoomApplicationContractsModule)
)]
public class MeetingRoomDbMigratorModule : AbpModule
{
}
