using MeetingRoom.Samples;
using Xunit;

namespace MeetingRoom.EntityFrameworkCore.Applications;

[Collection(MeetingRoomTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MeetingRoomEntityFrameworkCoreTestModule>
{

}
