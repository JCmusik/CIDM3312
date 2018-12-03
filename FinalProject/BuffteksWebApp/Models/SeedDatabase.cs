using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BuffteksWebApp.Models
{
    public class SeedDatabase
    {
        public static void Seed(IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetRequiredService<AppDbContext>();
            db.Database.Migrate();

            List<Project> projects;

            if (!db.Members.Any())
            {
                //Create at least ten Members
                // Create at least two clients

                // Create at least two projects
                projects = new List<Project>
                {
                        new Project
                        {
                            Title = "Kids Inc Webpage",
                            BeginDate = DateTime.Parse("12/14/2018"),
                            EndDate = DateTime.Parse("12/14/2019"),
                            TotalHours = 2000,
                            Client = new Client
                            {
                                FirstName = "Kids",
                                LastName = "Inc",
                                PhoneNumber = "806-376-5936",
                                Email = "info@kidsinc.org"
                            },
                                Members = new List<Member>
                                {
                                    new Member
                                    {
                                        FirstName = "John",
                                        LastName = "Cunningham",
                                        PhoneNumber = "806-555-1111",
                                        Email = "john@email.com"

                                    },
                                    new Member
                                    {
                                        FirstName = "Mara",
                                        LastName = "Kinoff",
                                        PhoneNumber = "806-555-1112",
                                        Email = "mara@email.com"
                                    },
                                    new Member
                                    {
                                        FirstName = "Gabby",
                                        LastName = "Cumbest",
                                        PhoneNumber = "806-555-1113",
                                        Email = "gabby@email.com"
                                    },
                                    new Member
                                    {
                                        FirstName = "Amy",
                                        LastName = "Saysouriyosack",
                                        PhoneNumber = "806-555-1114",
                                        Email = "amy@email.com"
                                    },
                                    new Member
                                    {
                                        FirstName = "Cesareo",
                                        LastName = "Lona",
                                        PhoneNumber = "806-555-1115",
                                        Email = "cesar@email.com"
                                    }
                                },
                        },
                        new Project
                        {
                            Title = "Palace Coffee Database",
                            BeginDate = DateTime.Parse("12/14/2018"),
                            EndDate = DateTime.Parse("6/14/2019"),
                            TotalHours = 1000,
                            Client = new Client
                            {
                                FirstName = "Palace",
                                LastName = "Coffee",
                                PhoneNumber = "806-476-0111",
                                Email = "info@palacecoffee.com"
                            },
                            Members = new List<Member>
                            {
                                new Member
                                {
                                    FirstName = "Michael",
                                    LastName = "Matthews",
                                    PhoneNumber = "806-555-1116",
                                    Email = "michael@email.com"
                                },
                                        new Member
                                {
                                    FirstName = "Mason",
                                    LastName = "McCollum",
                                    PhoneNumber = "806-555-1117",
                                    Email = "mason@email.com"
                                },
                                new Member
                                {
                                    FirstName = "Catherine",
                                    LastName = "McGovern",
                                    PhoneNumber = "806-555-1118",
                                    Email = "catherine@email.com"
                                },
                                new Member
                                {
                                    FirstName = "Quan",
                                    LastName = "Nyguyen",
                                    PhoneNumber = "806-555-1119",
                                    Email = "quan@email.com"
                                },
                                new Member
                                {
                                    FirstName = "Vanessa",
                                    LastName = "Valenzuela",
                                    PhoneNumber = "806-555-1120",
                                    Email = "vanessa@email.com"
                                }
                            }
                        }
                    };
            }
            else
                return;  // database has already been seeded

            db.Projects.AddRange(projects);
            db.SaveChanges();

            //Assign Members and Clients to Projects
        }
    }
}
