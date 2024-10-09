using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class IdentityUserCreateModalPage : ContentPage, ITransientDependency
{
    public IdentityUserCreateModalPage(IdentityUserCreateViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}