using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuffteksWebApp.Models;
using BuffteksWebApp.Logic;

namespace BuffteksWebApp.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _context;
        private ISorting _sorter;

        public ProjectController(AppDbContext context, ISorting sorter)
        {
            _context = context;
            _sorter = sorter;
        }

        // GET: Project
        public async Task<IActionResult> Index(string searchString)
        {
            return View(await _context.Projects.AsNoTracking().ToListAsync());
        }


        public IActionResult Search()
        {
            return View();
        }

        public async Task<IActionResult> SearchResults(string searchString)
        {
            // find project by title
            var project = await _context.Projects
                .FirstOrDefaultAsync(m => m.Title.Contains(searchString));

            if (project == null)
            {
                return RedirectToAction("Search");
            }

            var projDetails = _sorter.ProjectJoinMembersClients(_context, project);


            return View(projDetails);
        }

        // GET: Project/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .FirstOrDefaultAsync(m => m.ProjectID == id);

            if (project == null)
            {
                return NotFound();
            }

            var projDetails = _sorter.ProjectJoinMembersClients(_context, project);

            return View(projDetails);
        }


        // GET: Project/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectID,Title,BeginDate,EndDate,TotalHours")] Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        public async Task<IActionResult> ProjectAddNew(int id, Project project)
        {
            project = await _context.Projects.FindAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            var projP = _sorter.MembersClientsNotInProject(_context, project);
            var memSort = projP.Members;
            var cliSort = projP.Clients;

            List<SelectListItem> memberList = new List<SelectListItem>();
            List<SelectListItem> clientList = new List<SelectListItem>();

            foreach (var m in memSort)
            {
                memberList.Add(new SelectListItem { Value = m.ID.ToString(), Text = m.ToString() });
            }

            foreach (var c in cliSort)
            {
                clientList.Add(new SelectListItem { Value = c.ID.ToString(), Text = c.ToString() });
            }

            var projDetails = new ProjectAddViewModel()
            {
                PAVID = id,
                NewProject = project,
                MemberList = memberList,
                ClientList = clientList
            };

            return View(projDetails);
        }


        [HttpPost]
        public async Task<IActionResult> AddMemberToProject(int id, ProjectAddViewModel project)
        {
            if (ModelState.IsValid)
            {
                var proj = await _context.Projects.SingleOrDefaultAsync(c => c.ProjectID == id);
                var member = await _context.Members.SingleOrDefaultAsync(c => c.ID == project.SelectID);

                var cliToAdd = new ProjectPerson
                {
                    Project = proj,
                    ProjectID = project.PAVID,
                    Person = member,
                    PersonID = member.ID
                };

                _context.ProjectPersons.Add(cliToAdd);
                await _context.SaveChangesAsync();


                return RedirectToRoute(new
                {
                    controller = "Project",
                    action = "Details",
                    id = id
                });
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddClientToProject(int id, ProjectAddViewModel project)
        {
            if (ModelState.IsValid)
            {
                var proj = await _context.Projects.SingleOrDefaultAsync(c => c.ProjectID == id);
                var client = await _context.Clients.SingleOrDefaultAsync(c => c.ID == project.SelectID);

                var cliToAdd = new ProjectPerson
                {
                    Project = proj,
                    ProjectID = project.PAVID,
                    Person = client,
                    PersonID = client.ID
                };

                _context.ProjectPersons.Add(cliToAdd);
                await _context.SaveChangesAsync();


                return RedirectToAction("Index");
            }

            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> DeleteMemberFromProject(int id, ProjectAddViewModel project)
        {
            if (ModelState.IsValid)
            {
                var proj = await _context.Projects.SingleOrDefaultAsync(c => c.ProjectID == id);
                var client = await _context.Members.SingleOrDefaultAsync(c => c.ID == project.SelectID);

                var cliToAdd = new ProjectPerson
                {
                    Project = proj,
                    ProjectID = project.PAVID,
                    Person = client,
                    PersonID = client.ID
                };

                _context.ProjectPersons.Remove(cliToAdd);
                await _context.SaveChangesAsync();


                return RedirectToRoute("removeFromProj");
            }

            return NotFound();
        }

        // GET: Project/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectID,Title,BeginDate,EndDate,TotalHours")] Project project)
        {
            if (id != project.ProjectID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ProjectID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Project/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            var projDetails = _sorter.ProjectJoinMembersClients(_context, project);

            var mem = projDetails.Members;
            var client = projDetails.Clients;

            for (var i = 0; i < mem.Count; i++)
            {

                _context.ProjectPersons.Remove(
                    new ProjectPerson
                    {
                        ProjectID = project.ProjectID,
                        Project = project,
                        PersonID = mem[i].ID,
                        Person = mem[i]
                    }
                );
            }

            for (var i = 0; i < client.Count; i++)
            {

                _context.ProjectPersons.Remove(
                    new ProjectPerson
                    {
                        ProjectID = project.ProjectID,
                        Project = project,
                        PersonID = client[i].ID,
                        Person = client[i]
                    }
                );
            }
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(e => e.ProjectID == id);
        }
    }
}
