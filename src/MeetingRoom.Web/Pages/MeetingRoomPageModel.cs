using MeetingRoom.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MeetingRoom.Web.Pages;

public abstract class MeetingRoomPageModel : AbpPageModel
{
    protected MeetingRoomPageModel()
    {
        LocalizationResourceType = typeof(MeetingRoomResource);
    }
}
