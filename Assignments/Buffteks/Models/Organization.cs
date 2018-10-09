namespace Buffteks.Models
{
    public class Organization
    {
        #region Properties
            
            public int OrganizationID { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Name { get; set; }

        #endregion

        #region Methods
            
            public override string ToString() => $"ID: {this.OrganizationID} Organization: {this.Name}\nEmail: {this.Email}\nPhone Number: {this.PhoneNumber}";

        #endregion
    }
}