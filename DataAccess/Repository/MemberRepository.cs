using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository:IMemberRepository
    {
        public MemberObject GetMember(string MemberId) => MemberDAO.Instance.GetMember(MemberId);
        public IEnumerable<MemberObject> GetCars() => MemberDAO.Instance.GetAllMembers;
        public void Addnew(MemberObject member) => MemberDAO.Instance.AddNew(member);
        public void Delete(int MemberId) => MemberDAO.Instance.Remove(MemberId);
        public void Update(MemberObject member) => MemberDAO.Instance.Update(member);
    }
}
