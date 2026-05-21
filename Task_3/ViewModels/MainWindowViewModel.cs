using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Task_3.Models;

namespace Task_3.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string _newNoteTitle = string.Empty;
    [ObservableProperty] [NotifyPropertyChangedFor(nameof(HasSelectedNote), nameof(StatusNote))] private NoteItem? _selectedNote;
    public bool HasSelectedNote => SelectedNote is not null;
    public string StatusNote => SelectedNote is not null ? "Item:" : "Choose any item";
    
    public ObservableCollection<NoteItem> Notes { get; } = new()
    {
        new NoteItem("Buy Bread", "You need to buy bread", null),
        new NoteItem("Doctor", "Go to doctor", true),
        new NoteItem("Learn C#", null, null)
    };
    
    [RelayCommand]
    public void Add()
    {
        var note = new NoteItem((string.IsNullOrWhiteSpace(NewNoteTitle) ? "None" : NewNoteTitle), null, null);
        
        Notes.Add(note);
        SelectedNote = note;
        NewNoteTitle = "";
    }
    
    [RelayCommand]
    public void Delete()
    {
        if (SelectedNote != null)
        {
            Notes.Remove(SelectedNote);
        }
    }
}