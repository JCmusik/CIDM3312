namespace LINQPractice.Models
{
    public class Student
    {
        
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte TableNumber { get; set; }   
        public ClassRank ClassRank { get; set; }


        #region Methods
            public override string ToString() => $"{this.FirstName} {this.LastName}\n{this.Email}\nClassification: {this.ClassRank}\nTable: {this.TableNumber}\n";
        #endregion
    }
}