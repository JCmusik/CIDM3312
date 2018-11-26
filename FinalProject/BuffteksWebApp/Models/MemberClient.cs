namespace BuffteksWebApp.Models
{
    public class MemberClient
    {
        public int MemberID { get; set; }
        public Member Member { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
    }
}