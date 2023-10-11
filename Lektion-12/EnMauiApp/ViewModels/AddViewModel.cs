using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnMauiApp.Models;
using EnMauiApp.Services;

namespace EnMauiApp.ViewModels;

public partial class AddViewModel : ObservableObject
{
    [ObservableProperty]
    ContactModel contact = new ContactModel();

    [RelayCommand]
    async Task Add()
    {
        // lägga till en kontakt i en lista
        ContactService.AddToList(Contact);

        Contact = new ContactModel();
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
