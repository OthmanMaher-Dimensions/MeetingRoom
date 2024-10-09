using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class SettingsPage : ContentPage, ITransientDependency
{
	public SettingsPage(SettingsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}