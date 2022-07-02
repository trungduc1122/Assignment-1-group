
namespace DataAccess
{
    using BusinessObject;
    using System.Data;
    using Microsoft.Data.SqlClient;
    public class MemberDAO
    {
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

        public MemberObject GetMemberById(int id)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string sql = " SELECT MemberID";
            return member;
        }
    }
}