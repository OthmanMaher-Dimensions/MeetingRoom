using MeetingRoom.Localization;
using Volo.Abp.Application.Services;

namespace MeetingRoom;

/* Inherit your application services from this class.
 */
public abstract class MeetingRoomAppService : ApplicationService
{
    protected MeetingRoomAppService()
    {
        LocalizationResource = typeof(MeetingRoomResource);
    }
}
