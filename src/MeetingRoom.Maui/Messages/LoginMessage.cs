using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MeetingRoom.Maui.Messages;
public class LoginMessage : ValueChangedMessage<bool?>
{
    public LoginMessage(bool? value = null) : base(value)
    {
    }
}
