using MeetingRoom.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MeetingRoom.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MeetingRoomController : AbpControllerBase
{
    protected MeetingRoomController()
    {
        LocalizationResource = typeof(MeetingRoomResource);
    }
}
