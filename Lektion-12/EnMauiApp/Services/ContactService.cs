using EnMauiApp.Models;

namespace EnMauiApp.Services;

public static class ContactService
{
    private static List<ContactModel> contacts = new List<ContactModel>();
    public static event Action ContactsUpdated;


    public static void AddToList(ContactModel contact)
    {
        contacts.Add(contact);
        ContactsUpdated.Invoke();
    }

    public static List<ContactModel> GetContacts()
    {
        return contacts;
    }
}
