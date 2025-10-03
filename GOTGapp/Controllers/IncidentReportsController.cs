using GOTGapp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

public class IncidentReportsController : Controller
{
    private readonly ApplicationDbContext _context;

    public IncidentReportsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var reports = await _context.IncidentReports.ToListAsync();
        return View(reports);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(IncidentReport report)
    {
        if (ModelState.IsValid)
        {
            _context.Add(report);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(report);
    }

    public async Task<IActionResult> Details(int id)
    {
        var report = await _context.IncidentReports.FindAsync(id);
        if (report == null) return NotFound();
        return View(report);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var report = await _context.IncidentReports.FindAsync(id);
        if (report == null) return NotFound();
        return View(report);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, IncidentReport report)
    {
        if (id != report.ID) return NotFound();
        if (ModelState.IsValid)
        {
            _context.Update(report);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(report);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var report = await _context.IncidentReports.FindAsync(id);
        if (report == null) return NotFound();
        return View(report);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var report = await _context.IncidentReports.FindAsync(id);
        _context.IncidentReports.Remove(report);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
