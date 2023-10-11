using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EnMauiApp.Models;
using EnMauiApp.Services;
using EnMauiApp.Views;
using System.Collections.ObjectModel;

namespace EnMauiApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        UpdateContacts();
        ContactService.ContactsUpdated += UpdateContacts;
    }

    [ObservableProperty]
    ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();

    void UpdateContacts()
    {
        Contacts.Clear();
        foreach (var contact in ContactService.GetContacts())
            Contacts.Add(contact);
    }

    [RelayCommand]
    async Task GoToAdd()
    {
        await Shell.Current.GoToAsync(nameof(AddPage));
    }

    [RelayCommand]
    async Task GoToDetails(ContactModel contact)
    {
        var navigationParameter = new Dictionary<string, object>
            {
                { "Contact", contact }
            };

        await Shell.Current.GoToAsync(nameof(DetailsPage), navigationParameter);
    }
}
