using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class IdentityUserPage : ContentPage, ITransientDependency
{
	public IdentityUserPage(IdentityUserPageViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
	}
}