using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetAllMembers();
        IEnumerable<MemberObject> GetMember(String id);
        public void addMember(MemberObject member);
        public void updateMember(MemberObject member);
        public void deleteMember(String id);

    }
}
