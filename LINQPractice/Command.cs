using System;
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
                new Student { FirstName = "John", LastName = "Cunningham", Rank = "Senior", Email = "john@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Mara", LastName = "Kinoff", Rank = "Senior", Email = "mara@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Matthew", LastName = "Matthews", Rank = "Senior", Email = "michael@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Laith", LastName = "Alfaloujeh", Rank = "Senior", Email = "laith@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Mekkala", LastName = "Bourapa", Rank = "Senior", Email = "mekkala@wtamu.edu", TableNumber = 1},
                new Student { FirstName = "Charles", LastName = "Coufal", Rank = "Senior", Email = "Charles@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Michael", LastName = "Hayes", Rank = "Senior", Email = "Michael@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Aaron", LastName = "Hebert", Rank = "Senior", Email = "Aaron@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Yi Fu", LastName = "Ji", Rank = "Senior", Email = "YiFu@wtamu.edu", TableNumber = 3},
                new Student { FirstName = "Todd", LastName="Kile", Rank="Junior", Email="Todd@email.com", TableNumber =  4},
                new Student { FirstName = "Cesareo", LastName="", Rank="Senior", Email="Cesareo@wtamu.edu", TableNumber =  3},
                new Student { FirstName = "Mason", LastName="McCollum", Rank="Junior", Email="Mason@email.com", TableNumber =  1},
                new Student { FirstName = "Alexander", LastName="McDonald", Rank="Junior", Email="Alexander@email.com", TableNumber =  1},
                new Student { FirstName = "Phelps", LastName="Merrell", Rank="Junior", Email="Phelps@email.com", TableNumber =  4},
                new Student { FirstName = "Quan", LastName="Nguyen", Rank="Senior", Email="Quan@email.com", TableNumber =  1},
                new Student { FirstName = "Alexander", LastName="Roder", Rank="Senior", Email="Alexander@email.com", TableNumber =  2},
                new Student { FirstName = "Amy", LastName="Saysouriyosack", Rank="Senior", Email="amy@wtamu.com", TableNumber =  3},
                new Student { FirstName = "Claudia", LastName="Silva", Rank="Junior", Email="Claudia@email.com", TableNumber =  3},
                new Student { FirstName = "Vanessa", LastName="Valenzuela", Rank="Senior", Email="Gabriela@email.com", TableNumber =  4},
                new Student { FirstName = "Kayla", LastName="Washington", Rank="Sophomore", Email="Kayla@email.com", TableNumber =  1},
                new Student { FirstName = "Matthew", LastName="Webb", Rank="Junior", Email="Matthew@email.com", TableNumber =  2},

                new Student { FirstName = "Cory", LastName="", Rank="Junior", Email="Cory@email.com", TableNumber =  1},
                new Student { FirstName = "Catherine", LastName="McGovern", Rank="Senior", Email="Catherine@email.com", TableNumber =  1}
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

        // students who are not seniors
        public static void StudentsNotSeniorsQuerySyntax()
        {
            using (var db = new AppDbContext())
            {
                
            }
        }
        public static void StudentsNotSeniorsMethodSyntax()
        {
            
        }

        //students whose first names begin with letters 'M' or lower
        public static void StudentsFirstNameMQuerySyntax()
        {
            
        }
        public static void StudentsFirstNameMMethodSyntax()
        {
            
        }

        // students whose first names begin with letters 'L' or lower
        public static void StudentsFirstNameLQuerySyntax()
        {
            
        }
        public static void StudentsFirstNameMLethodSyntax()
        {
            
        }

        // Connect to the database and show all students who have taken CIDM3350 previously (hint: maybe you need to refactor
        public static void StudentTakenCIDM3350querysyntax()
        {
            
        }

        public static void StudentTakenCIDM3350methodsyntax()
        {
            
        }


    }
}