using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MeetingRoom.Pages;

[Collection(MeetingRoomTestConsts.CollectionDefinitionName)]
public class Index_Tests : MeetingRoomWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
