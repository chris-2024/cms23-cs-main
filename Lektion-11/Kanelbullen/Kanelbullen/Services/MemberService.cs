using Kanelbullen.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Kanelbullen.Services;

public class MemberService
{
    private List<MemberModel> _members;

    public MemberService()
    {
        _members = new List<MemberModel>();
    }

    public event Action MembersUpdated;

    public void AddMemberToList(MemberModel member)
    {
        _members.Add(member);
        MembersUpdated.Invoke();
    }

    public void RemoveMember(MemberModel member)
    {
        //_members.Remove(_members.Where(m => m.Id == memberId).First());
        _members.Remove(member);
        MembersUpdated.Invoke();
    }

    public List<MemberModel> GetMembers()
    {
        return _members;
    }
}
