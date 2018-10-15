using System.Collections.Generic;

namespace Models.Models
{
    public class Advisor : Person
    {
        #region Properties

            public int AdvisorID { get; set; }
            public string Title { get; set; }
            
        #endregion

        #region Methods
            
            public override string ToString() => $"Title: {this.Title}\nName: {this.FirstName} {this.LastName}\nPhone Number: {this.PhoneNumber}\nEmail: {this.Email}";

        #endregion
    }
}