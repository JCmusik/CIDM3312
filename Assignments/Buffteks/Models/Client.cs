namespace Models.Models
{
    public class Client : Person
    {
        public int ClientID { get; set; }
        public int OrganizationID { get; set; }
        public Organization Organization { get; set; }

        #region Methods
            
            public override string ToString() => $"Organization: {this.Organization}\nName: {this.FirstName} {this.LastName}\nEmail: {this.Email}";

        #endregion
    }
}