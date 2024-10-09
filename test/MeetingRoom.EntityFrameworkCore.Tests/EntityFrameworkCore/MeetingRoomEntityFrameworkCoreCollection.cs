using Xunit;

namespace MeetingRoom.EntityFrameworkCore;

[CollectionDefinition(MeetingRoomTestConsts.CollectionDefinitionName)]
public class MeetingRoomEntityFrameworkCoreCollection : ICollectionFixture<MeetingRoomEntityFrameworkCoreFixture>
{

}
