namespace BusinessObject
{
    public class MemberObject
    {
        public string MemberID { get; set; }
        public string Password { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public MemberObject()
        {

        }
        public MemberObject(string memberID, string password, string memberName, string email, string city, string country)
        {
            MemberID = memberID;
            Password = password;
            MemberName = memberName;
            Email = email;
            City = city;
            Country = country;
        }
    }
}