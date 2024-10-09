using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class ChangePasswordPage : ContentPage, ITransientDependency
{
	public ChangePasswordPage(ChangePasswordViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}