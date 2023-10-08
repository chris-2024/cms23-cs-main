using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Models;
using Kanelbullen.Services;
using Kanelbullen.Views;

namespace Kanelbullen.ViewModels;

public partial class DetailViewModel : ObservableObject
{
    private readonly MemberService _memberService;

    private readonly MemberModel _member;

    [ObservableProperty]
    private string firstName;

    [ObservableProperty]
    private string lastName;

    [ObservableProperty]
    private string email;

    public DetailViewModel(MemberModel member, MemberService memberService)
    {
        _memberService = memberService;
        _member = member;

        firstName = _member.FirstName;
        lastName = _member.LastName;
        email = _member.Email;
    }

    [RelayCommand]
    public async Task DeleteMember()
    {
        _memberService.RemoveMember(_member);
        await Shell.Current.GoToAsync("..");
    }
}
