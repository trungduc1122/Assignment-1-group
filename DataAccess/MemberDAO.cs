
namespace DataAccess
{
    using BusinessObject;
    using System.Data;
    using Microsoft.Data.SqlClient;
    public class MemberDAO
    {
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject { MemberID = "SE10000", Password = "abcxyz123", MemberName = "Mmmmmmmm",
                               Email = "vnj@gmail.com", City = "HCM", Country = "country" }
        };
        private static MemberDAO instance=null;
        private static readonly object instanceLock=null;
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }

        public List<MemberObject> GetAllMembers => MemberList;
        public MemberObject GetMember(string id)
        {
            {
                //using LINQ to Object
                MemberObject memberObject = MemberList.SingleOrDefault(pro => pro.MemberID.Equals(id));
                return memberObject;
            }

        }
        public void AddNew(MemberObject member)
        {
            MemberObject pro = GetMember(member.MemberID);
            if (pro == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exists.");
            }
        }
        public void Update(MemberObject member)
        {
            MemberObject c = GetMember(member.MemberID);
            if (c != null)
            {
                var index = MemberList.IndexOf(c);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        public void Remove(int memberID)
        {
            MemberObject p = GetMember(memberID.memberID);
            if (p != null)
            {
                MemberList.Remove(p);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
}