using Volo.Abp.Settings;

namespace MeetingRoom.Settings;

public class MeetingRoomSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MeetingRoomSettings.MySetting1));
    }
}
