using CommunityToolkit.Mvvm.ComponentModel;

namespace Task_3.Models;

public partial class NoteItem : ObservableObject
{
    [ObservableProperty] private string _title = string.Empty;
    [ObservableProperty] private string _text = string.Empty;
    [ObservableProperty] private bool _isImportant;

    public NoteItem(string? title, string? text, bool? isImportant)
    {
        Title = title ?? "None";
        Text = text ?? "None";
        IsImportant = isImportant ?? false;
    }
}