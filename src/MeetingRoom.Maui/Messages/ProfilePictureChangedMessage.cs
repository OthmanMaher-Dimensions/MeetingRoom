using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MeetingRoom.Maui.Messages;

public class ProfilePictureChangedMessage : ValueChangedMessage<string>
{
    public ProfilePictureChangedMessage(string value) : base(value)
    {
    }
}
