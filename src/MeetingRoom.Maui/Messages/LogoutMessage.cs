﻿using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MeetingRoom.Maui.Messages;
public class LogoutMessage : ValueChangedMessage<bool?>
{
    public LogoutMessage(bool? value = null) : base(value)
    {
    }
}