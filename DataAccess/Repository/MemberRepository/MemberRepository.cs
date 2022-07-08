using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository.MemberRepository
{
    public class MemberRepository
    {
        public bool IsAdminLogin(string email, string password) => MemberDAO.GetMemberDao.IsAdminLogin(email, password);
        public void AddMember(Member member) => MemberDAO.GetMemberDao.AddMember(member);

        public void DeleteMember(int memberId) => MemberDAO.GetMemberDao.Delete(memberId);

        public IEnumerable<Member> GetMembersList()
        {
            return MemberDAO.GetMemberDao.GetMembersList();
        }

        public IEnumerable<Member> SearchMember(string name)
        {
            return MemberDAO.GetMemberDao.SearchMember(name);
        }

        public Member Login(string email, string password)
        {
            return MemberDAO.GetMemberDao.Login(email, password);
        }

        public void UpdateMember(Member member) => MemberDAO.GetMemberDao.Update(member);

        public IEnumerable<Member> SearchMemberByCountry(string country, IEnumerable<Member> searchList)
        {
            return MemberDAO.GetMemberDao.FilterMemberByCountry(country, searchList);
        }

        public IEnumerable<Member> SearchMemberByCity(string country, string city, IEnumerable<Member> searchList)
        {
            return MemberDAO.GetMemberDao.FilterMemberByCity(country, city, searchList);
        }

        public Member GetMember(int memberId)
        {
            return MemberDAO.GetMemberDao.GetMemberByMemberId(memberId);
        }

        public int GetNextMemberId()
        {
            return MemberDAO.GetMemberDao.GetNextMemberId();
        }

        public Member GetMember(string email) => MemberDAO.GetMemberDao.GetMemberByEmail(email);
    }
}
