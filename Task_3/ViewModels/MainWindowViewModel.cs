using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Task_3.Models;

namespace Task_3.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private NoteItem? _selectedNote;
    
    public ObservableCollection<NoteItem> NoteItems { get; } = new()
    {
        new NoteItem("Buy Bread", "You need to buy bread", null),
        new NoteItem("Doctor", "Go to doctor", true),
        new NoteItem("Learn C#", null, null)
    };
    
    [RelayCommand]
    public void Add()
    {
        NoteItems.Add(new NoteItem(null, null, null));
    }
    
    [RelayCommand]
    public void Delete()
    {
        if (SelectedNote != null)
        {
            NoteItems.Remove(SelectedNote);
        }
    }
}