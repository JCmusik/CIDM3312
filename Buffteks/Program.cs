using System;
using Buffteks.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Buffteks
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var team = context.Team.AsNoTracking().Include(s => s.Student);
                
                foreach (var t in team)
                {
                    System.Console.WriteLine($"Team Name: {t.Name}");
                    System.Console.WriteLine($"{t.Student.FirstName}");
                }
            }
        }
    }
}
