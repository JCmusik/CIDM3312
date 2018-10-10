namespace LINQPractice.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Rank { get; set; }
        public byte TableNumber { get; set; }   


        #region Methods
            public override string ToString() => $"{this.FirstName} {this.LastName}\n{this.Email}\nClassification: {this.Rank}\nTable: {this.TableNumber}\n";
        #endregion
    }
}