using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class LoginOrLogoutPage : ContentPage, ITransientDependency
{
	public LoginOrLogoutPage(LoginOrLogoutViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}