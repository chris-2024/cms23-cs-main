using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Models;
using Kanelbullen.Services;
using Kanelbullen.Views;

namespace Kanelbullen.ViewModels;

public partial class EditViewModel : ObservableObject
{
    private readonly MemberService _memberService;

    public EditViewModel(MemberService memberService)
    {
        _memberService = memberService;
    }

    public EditViewModel(MemberService memberService, MemberModel member)
    {
        _memberService = memberService;
        firstName = member.FirstName;
        lastName = member.LastName;
        email = member.Email;
    }

    [ObservableProperty]
    private string firstName;

    [ObservableProperty]
    private string lastName;

    [ObservableProperty]
    private string email;


    [RelayCommand]
    public async Task Save()
    {
        var member = new MemberModel()
        {
            FirstName = FirstName,
            LastName = LastName,
            Email = Email
        };

        _memberService.AddMemberToList(member);

        await Shell.Current.GoToAsync("..");
    }
}
