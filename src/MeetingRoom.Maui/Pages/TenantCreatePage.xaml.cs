using MeetingRoom.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.Pages;

public partial class TenantCreatePage : ContentPage, ITransientDependency
{
    public TenantCreatePage(TenantCreateViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
