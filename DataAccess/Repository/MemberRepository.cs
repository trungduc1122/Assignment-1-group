using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void addMember(MemberObject member)=>MemberDAO.Instance.AddNew(member);

        public void deleteMember(MemberObject member) => MemberDAO.Instance.Remove(member);

        public List<MemberObject> GetAllMembers() => MemberDAO.Instance.GetAllMembers();

        public MemberObject GetMember(string id) => MemberDAO.Instance.GetMember(id);

        public void updateMember(MemberObject member) => MemberDAO.Instance.Update(member);
    }
}
