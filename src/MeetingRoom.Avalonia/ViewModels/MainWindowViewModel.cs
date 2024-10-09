using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MeetingRoom.Avalonia.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    #pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to !";
    #pragma warning restore CA1822 // Mark members as static
   
    [ObservableProperty]
    private bool _isPaneOpen = false;
    
    [ObservableProperty]
    private ViewModelBase _currentPage = new HomePageViewModel();

    [ObservableProperty] 
    private ListItemTemplate? _selectedListItem;

    partial void OnSelectedListItemChanged(ListItemTemplate? value)
    {
        if (value is null) return;
        var instance = Activator.CreateInstance(value.ModelType);
        if (instance is null) return;
        CurrentPage = (ViewModelBase)instance;
    }
    public ObservableCollection<ListItemTemplate> Items { get; } = new()
    {
        new ListItemTemplate(typeof(HomePageViewModel), "HomeRegular"),
        new ListItemTemplate(typeof(MeetingPageViewModel), "MeetNow"),
        new ListItemTemplate(typeof(FilesPageViewModel), "Folder"),
        new ListItemTemplate(typeof(UploadPageViewModel), "Upload"),
        new ListItemTemplate(typeof(ChatPageViewModel), "Chat"),
        new ListItemTemplate(typeof(CateringPageViewModel), "Catering"),
        new ListItemTemplate(typeof(NotificationsPageViewModel), "Notification")
    };
    
    [RelayCommand]
    private void TriggerPane()
    {
        IsPaneOpen = !IsPaneOpen;
    }
    
    
}

public class ListItemTemplate
{
    public ListItemTemplate(Type type, string iconKey)
    {
        ModelType = type;
        Label = type.Name.Replace("PageViewModel", "");
        
        Application.Current!.TryFindResource(iconKey, out var icon);

        ListItemIcon = (StreamGeometry)icon!;
    }
    public string Label { get;}
    public Type ModelType { get; }
    public StreamGeometry ListItemIcon { get;  }
}