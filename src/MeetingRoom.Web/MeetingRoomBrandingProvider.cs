using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Web;

[Dependency(ReplaceServices = true)]
public class MeetingRoomBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MeetingRoom";
}
