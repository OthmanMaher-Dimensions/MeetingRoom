using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class ProfilePicturePage : ContentPage, ITransientDependency
{
    public ProfilePicturePage(ProfilePictureViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}