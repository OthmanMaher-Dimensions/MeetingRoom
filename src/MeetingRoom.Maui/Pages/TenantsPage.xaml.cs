using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class TenantsPage : ContentPage, ITransientDependency
{
	public TenantsPage(TenantsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
