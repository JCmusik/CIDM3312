using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MVC.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.Migrate();
            if (!context.Students.Any())
            {
                context.AddRange(
                new Student
                    {
                        FirstName = "Gabrielle",
                        LastName = "Ashley",
                        Email = "gabrielle@email.com",
                        PhoneNumber = "XXX-XXX-XXXX",
                    },
                    new Student
                    {
                        FirstName = "Mara",
                        LastName = "Kinoff",
                        Email = "mara@email.com",
                        PhoneNumber = "XXX-XXX-XXXX"
                    },
                    new Student
                    {
                        FirstName = "John",
                        LastName = "Cunningham",
                        Email = "john@email.com",
                        PhoneNumber = "XXX-XXX-XXXX",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}