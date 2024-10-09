using CommunityToolkit.Mvvm.Input;
using Volo.Abp.DependencyInjection;

namespace MeetingRoom.Maui.ViewModels;

public partial class MainPageViewModel : MeetingRoomViewModelBase, ITransientDependency
{
    public MainPageViewModel()
    {
    }

    [RelayCommand]
    async Task SeeAllUsers()
    {
        await Shell.Current.GoToAsync("///users");
    }
}
