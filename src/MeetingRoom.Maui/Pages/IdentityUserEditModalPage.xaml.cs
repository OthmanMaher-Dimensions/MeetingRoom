using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class IdentityUserEditModalPage : ContentPage, ITransientDependency
{
	public IdentityUserEditModalPage(IdentityUserEditViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}