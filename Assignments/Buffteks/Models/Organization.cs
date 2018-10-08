namespace Buffteks.Models
{
    public class Organization : Person
    {
        #region Properties
            
            public int OrganizationID { get; set; }
            public string Name { get; set; }


        #endregion

        #region Methods
            
            public override string ToString() => $"Organization: {this.Name}\nEmail: {this.Email}\nPhone Number: {this.PhoneNumber}";

        #endregion
    }
}