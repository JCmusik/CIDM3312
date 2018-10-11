using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LINQPractice.Models;

namespace LINQPractice
{
    public class Command
    {
        public static void SeedDatabase()
        {
            var students = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Cunningham", ClassRank = ClassRank.Senior, Email = "john@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Mara", LastName = "Kinoff", ClassRank = ClassRank.Senior, Email = "mara@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Matthew", LastName = "Matthews", ClassRank = ClassRank.Senior, Email = "michael@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Laith", LastName = "Alfaloujeh", ClassRank = ClassRank.Senior, Email = "laith@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Mekkala", LastName = "Bourapa", ClassRank = ClassRank.Senior, Email = "mekkala@wtamu.edu", TableNumber = 1},
                new Student { FirstName = "Charles", LastName = "Coufal", ClassRank = ClassRank.Senior, Email = "Charles@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Michael", LastName = "Hayes", ClassRank = ClassRank.Senior, Email = "Michael@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Aaron", LastName = "Hebert", ClassRank = ClassRank.Senior, Email = "Aaron@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Yi", LastName = "Ji", ClassRank = ClassRank.Senior, Email = "YiFu@wtamu.edu", TableNumber = 3},
                new Student { FirstName = "Todd", LastName="Kile", ClassRank=ClassRank.Junior, Email="Todd@email.com", TableNumber =  4},
                new Student { FirstName = "Cesareo", LastName="Lona", ClassRank=ClassRank.Senior, Email="Cesareo@wtamu.edu", TableNumber =  3},
                new Student { FirstName = "Mason", LastName="McCollum", ClassRank=ClassRank.Junior, Email="Mason@email.com", TableNumber =  1},
                new Student { FirstName = "Alexander", LastName="McDonald", ClassRank=ClassRank.Junior, Email="Alexander@email.com", TableNumber =  1},
                new Student { FirstName = "Phelps", LastName="Merrell", ClassRank=ClassRank.Junior, Email="Phelps@email.com", TableNumber =  4},
                new Student { FirstName = "Quan", LastName="Nguyen", ClassRank=ClassRank.Senior, Email="Quan@email.com", TableNumber =  1},
                new Student { FirstName = "Alexander", LastName="Roder", ClassRank=ClassRank.Senior, Email="Alexander@email.com", TableNumber =  2},
                new Student { FirstName = "Amy", LastName="Saysouriyosack", ClassRank=ClassRank.Senior, Email="amy@wtamu.com", TableNumber =  3},
                new Student { FirstName = "Claudia", LastName="Silva", ClassRank=ClassRank.Junior, Email="Claudia@email.com", TableNumber =  3},
                new Student { FirstName = "Vanessa", LastName="Valenzuela", ClassRank=ClassRank.Senior, Email="Gabriela@email.com", TableNumber =  4},
                new Student { FirstName = "Kayla", LastName="Washington", ClassRank=ClassRank.Sophomore, Email="Kayla@email.com", TableNumber =  1},
                new Student { FirstName = "Matthew", LastName="Webb", ClassRank=ClassRank.Junior, Email="Matthew@email.com", TableNumber =  2},

                new Student { FirstName = "Cory", LastName="Williams", ClassRank=ClassRank.Junior, Email="Cory@email.com", TableNumber =  1},
                new Student { FirstName = "Catherine", LastName="McGovern", ClassRank=ClassRank.Senior, Email="Catherine@email.com", TableNumber =  1}
            };

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                
                if(!db.Students.Any())
                {
                    db.AddRange(students);
                    db.SaveChanges();
                }
                else
                {
                    foreach (var s in db.Students)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }



       
        // 2. Connect to the database and show all records of students who are not seniors
        public static void StudentsNotSeniorsQuerySyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students.ToList();
                var studentsNotSenior = from s in students
                                            where s.ClassRank != ClassRank.Senior
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
           
        }
        public static void StudentsNotSeniorsMethodSyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = students.Where(s => s.ClassRank != ClassRank.Senior);

                PrintToConsole(studentsNotSenior);

            }
            
        }

        // 3. Connect to the database and show all students whose first names begin with letters 'M' or lower
        public static void StudentsFirstNameMQuerySyntax()
        {
             using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsM = from s in students
                                where s.FirstName[0] >= 'M'
                                select s;

                PrintToConsole(studentsM);
            }
        }
        public static void StudentsFirstNameMMethodSyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsM = students.Where(f => f.FirstName[0] >= 'M');

                PrintToConsole(studentsM);
            }
        }

        // 4. Connect to the database and show all students whose last names begin with letters "L" or higher and whose first names are longer than 6 characters
        public static void StudentsFirstNameLQuerySyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsM = from s in students
                                where s.FirstName[0] >= 'M'
                                select s;
                var fNameLonger6Char = from s in studentsM
                                            where s.FirstName.Length > 6
                                            select s;

                PrintToConsole(fNameLonger6Char);
            }
        }
        public static void StudentsFirstNameLMethodSyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsL = students.Where(f => f.FirstName[0] <= 'L');
                var fNameLonger6Char = studentsL.Where( l => l.FirstName.Length > 6);

                PrintToConsole(fNameLonger6Char);
                
            }
        }

        

        
        // 5. Connect to the database and show all students who have taken CIDM3350 previously
        public static void StudentTakenCIDM3350querysyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsTaken3315 = from s in students
                                        where s.ClassRank == ClassRank.Senior
                                        select s;

                PrintToConsole(studentsTaken3315);
                
            }
        }

        public static void StudentTakenCIDM3350methodsyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsTaken3315 = students.Where(s => s.ClassRank == ClassRank.Senior);

                PrintToConsole(studentsTaken3315);
            }
        }


        // 1. Connect to the database and find a student named "John" and print that record to the screen
        public static void StudentNamedJohnMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedJohn = students.Where(s => s.FirstName == "John");

                PrintToConsole(studetnsNamedJohn);
            }
        }

        public static void StudentNamedJohnQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedJohn = from s in students
                                            where s.FirstName == "John"
                                            select s;

                PrintToConsole(studetnsNamedJohn);
            } 
        }

        // 2. Connect to the database and find a student named "Alexander" and print that record to the screen

        public static void StudentNamedAlexanderMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedAlexander = students.Where(s => s.FirstName == "Alexander");

                PrintToConsole(studetnsNamedAlexander);
            }
        }

        public static void StudentNamedAlexanderQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedAlexander = from s in students
                                                where s.FirstName == "Alexander"
                                                select s;

                PrintToConsole(studetnsNamedAlexander);
            } 
        }

        // 3. Connect to the database and find a student who has the shortest first name and print that record to the screen
        public static void StudentShortestFNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var minLength = students.Min(s => s.FirstName.Length);
                var studentsShortestFName = students.Where(f => f.FirstName.Length == minLength);
                

                PrintToConsole(studentsShortestFName);

            }
        }

        public static void StudentShortestFNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsFNameCount = from s in students
                                    orderby s.FirstName.Length
                                    select s;
                Console.WriteLine(studentsFNameCount.First());
            
            }

        }

        // 4. Connect to the database and find a student who has the shortest last name and print that record to the screen
        public static void StudentShortestLNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var minLength = students.Min(s => s.LastName.Length);
                var studentsShortestFName = students.Where(f => f.FirstName.Length == minLength);
                
                PrintToConsole(studentsShortestFName);

            }
        }

        public static void StudentShortestLNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsFNameCount= from s in students
                                            where s.FirstName.Length < 4
                                            select s;
                PrintToConsole(studentsFNameCount);
            }
        }

        // 5.  Connect to the database and find a student who has the shortest last name but also has the longest first name and print that record to the screen

        public static void StudentShortestLNameLongestFNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsFiltered = students.OrderBy( l => l.LastName.Length).ThenByDescending(f => f.FirstName.Length).Take(1);

                PrintToConsole(studentsFiltered);

            }
        }
        
        public static void StudentShortestLNameLongestFNameQuery()
        {  
             using (var db = new AppDbContext())
            {
                var students = db.Students;

                var studentFiltered = (from s in students
                                        orderby s.LastName.Length ascending, s.FirstName.Length descending
                                        select s).Take(1);

                PrintToConsole(studentFiltered);

                

            }

        }

        // 1. Connect to the database and show all students sorted by first name

        public static void SortByFirstNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = students.OrderBy(f => f.FirstName);
                
                PrintToConsole(studentsNotSenior);  

            }

        }

        public static void SortByFirstNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            orderby s.FirstName ascending
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        // 2. Connect to the database and show all students sorted by last name descending

        public static void SortByLastNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = students.OrderByDescending(f => f.LastName);
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        public static void SortByLastNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            orderby s.LastName descending
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        // 3. Connect to the database and show all students sorted by rank (Freshman, Sophomore, Junior, Senior, 

        public static void SortByRankMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var rankSort = students.OrderBy(r => r.ClassRank);

                PrintToConsole(rankSort);
            }
        }

        public static void SortByRankQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            orderby s.ClassRank
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        // 4.  Connect to the database and show students who are Seniors and sorted by last name
        public static void SeniorsSortLNameMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var studentsNotSenior = students.Where(r => r.ClassRank == ClassRank.Senior).OrderBy(l => l.LastName);
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        public static void SeniorsSortLNameQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            where s.ClassRank == ClassRank.Senior
                                            orderby s.LastName
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }
        // 5. Connect to the database and show students who are NOT Seniors and sorted by first name descending
        public static void NotSeniorsSortLNameMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var studentsNotSenior = students.Where(r => r.ClassRank != ClassRank.Senior).OrderByDescending(l => l.FirstName);
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        public static void NotSeniorsSortLNameQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            where s.ClassRank != ClassRank.Senior
                                            orderby s.FirstName descending
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }


        // 1. Connect to the database and show all students Grouped by class rank

        public static void GroupByClassRankMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = students.GroupBy(g => g.ClassRank);
                
                foreach (var c in classRank)
                {
                    Console.WriteLine("--------Grouped by class rank----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 

            }
        }

        public static void GroupByClassRankQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = from student in students
                                group student by student.ClassRank;

                foreach (var c in classRank)
                {
                    Console.WriteLine($"--------Grouped by {c.Key}----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 

            }
            
        }

        // 2. Connect to the database and show all students Grouped by class rank and sorted by last name

        public static void GroupByRankSortByLNameMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = students.OrderBy( l => l.LastName).GroupBy(r => r.ClassRank);
                
                foreach (var c in classRank)
                {
                    Console.WriteLine($"--------Grouped by {c.Key} ----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 

            }
        }

        public static void GroupByRankSortByLNameQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = from s in students
                                    orderby s.LastName
                                    group s by s.ClassRank;
                
                foreach (var c in classRank)
                {
                    Console.WriteLine($"--------Grouped by {c.Key} ----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 
            }
        }

        // 3. Connect to the database and show all students Grouped by the first letter of their last name and sorted by first name

        public static void GroupByFLetterLnameSortFNameMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = students.OrderBy( l => l.FirstName).GroupBy(r => r.LastName[0]);
                                    
                
                foreach (var c in classRank)
                {
                    Console.WriteLine($"--------Grouped by {c.Key} ----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 
            }
        }

        public static void GroupByFLetterLnameSortFNameQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = from st in students
                                    orderby st.FirstName
                                    group st by st.LastName[0];
                                    
                
                foreach (var c in classRank)
                {
                    Console.WriteLine($"--------Grouped by {c.Key} ----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 
            }
        }

         // print to console
        private static void PrintToConsole(IEnumerable<object> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
        }


    }
}