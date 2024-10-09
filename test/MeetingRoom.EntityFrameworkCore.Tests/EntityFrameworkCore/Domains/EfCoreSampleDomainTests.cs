using MeetingRoom.Samples;
using Xunit;

namespace MeetingRoom.EntityFrameworkCore.Domains;

[Collection(MeetingRoomTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MeetingRoomEntityFrameworkCoreTestModule>
{

}
