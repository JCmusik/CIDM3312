using System.Linq;
using BuffteksWebApp.Models;

namespace BuffteksWebApp.Logic
{
    public class Sorting : ISorting
    {
        IQueryable<Person> person;

        public IQueryable<Person> Sort(AppDbContext db, string sortOrder, string type)
        {

            switch (type)
            {
                case "Member":
                    person = from m in db.Members
                             select m;
                    break;
                case "Clients":
                    person = from c in db.Clients
                             select c;
                    break;
                default:
                    break;
            }

            switch (sortOrder)
            {
                case "first_name":
                    person = person.OrderBy(m => m.FirstName);
                    break;
                case "first_name_desc":
                    person = person.OrderByDescending(m => m.FirstName);
                    break;
                case "last_name":
                    person = person.OrderBy(m => m.LastName);
                    break;
                case "last_name_desc":
                    person = person.OrderByDescending(m => m.LastName);
                    break;
                case "email":
                    person = person.OrderBy(m => m.Email);
                    break;
                case "email_desc":
                    person = person.OrderByDescending(m => m.Email);
                    break;
                default:
                    person = person.OrderBy(m => m.LastName);
                    break;
            }

            return person;
        }

        public ProjectDetailViewModel ProjectJoinMembersClients(AppDbContext db, Project project)
        {

            var clients = from client in db.Clients
                          join projectPerson in db.ProjectPersons
                          on client.ID equals projectPerson.PersonID
                          where project.ProjectID == projectPerson.ProjectID
                          select client;

            var members = from member in db.Members
                          join projectperson in db.ProjectPersons
                          on member.ID equals projectperson.PersonID
                          where project.ProjectID == projectperson.ProjectID
                          select member;

            var projDetails = new ProjectDetailViewModel
            {
                Project = project,
                Members = members.ToList() ?? null,
                Clients = clients.ToList() ?? null
            };

            return projDetails;
        }

        public ProjectDetailViewModel MembersClientsNotInProject(AppDbContext db, Project project)
        {

            var clients = from client in db.Clients
                          join projectPerson in db.ProjectPersons
                          on client.ID equals projectPerson.PersonID
                          where project.ProjectID != projectPerson.ProjectID
                          select client;

            var members = from member in db.Members
                          join projectperson in db.ProjectPersons
                          on member.ID equals projectperson.PersonID
                          where project.ProjectID != projectperson.ProjectID
                          select member;

            var projDetails = new ProjectDetailViewModel
            {
                Project = project,
                Members = members.ToList() ?? null,
                Clients = clients.ToList() ?? null
            };

            return projDetails;
        }

    }
}