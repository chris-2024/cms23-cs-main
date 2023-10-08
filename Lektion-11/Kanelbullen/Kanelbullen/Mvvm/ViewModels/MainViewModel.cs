using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kanelbullen.Models;
using Kanelbullen.Services;
using Kanelbullen.Views;
using System.Collections.ObjectModel;

namespace Kanelbullen.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly MemberService _memberService;

    [ObservableProperty]
    private ObservableCollection<MemberModel> members;

    public MainViewModel(MemberService memberService)
    {
        _memberService = memberService;
        GetMembers();

        _memberService.MembersUpdated += GetMembers;
    }

    private void GetMembers()
    {
        Members = new ObservableCollection<MemberModel>(_memberService.GetMembers());
    }

    [RelayCommand]
    public async Task GoToDetail(MemberModel member)
    {
        var viewModel = new DetailViewModel(member, _memberService);
        var detailPage = new DetailPage(viewModel);
        await Shell.Current.Navigation.PushAsync(detailPage);
    }

    [RelayCommand]
    public async Task GoToEdit()
    {
        await Shell.Current.GoToAsync(nameof(EditPage));
    }
}
