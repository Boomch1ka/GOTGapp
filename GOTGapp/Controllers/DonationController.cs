using GOTGapp.Data;
using GOTGapp.Models;
using Microsoft.AspNetCore.Mvc;

public class DonationsController : Controller
{
    private readonly ApplicationDbContext _context;

    public DonationsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Donations.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Donation donation)
    {
        if (ModelState.IsValid)
        {
            _context.Add(donation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(donation);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        if (donation == null) return NotFound();
        return View(donation);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Donation donation)
    {
        if (id != donation.ID) return NotFound();
        if (ModelState.IsValid)
        {
            _context.Update(donation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(donation);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        if (donation == null) return NotFound();
        return View(donation);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        _context.Donations.Remove(donation);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        if (donation == null) return NotFound();
        return View(donation);
    }
}
public class DonationsController : Controller
{
    private readonly ApplicationDbContext _context;

    public DonationsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Donations.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Donation donation)
    {
        if (ModelState.IsValid)
        {
            _context.Add(donation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(donation);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        if (donation == null) return NotFound();
        return View(donation);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Donation donation)
    {
        if (id != donation.ID) return NotFound();
        if (ModelState.IsValid)
        {
            _context.Update(donation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(donation);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        if (donation == null) return NotFound();
        return View(donation);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        _context.Donations.Remove(donation);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(int id)
    {
        var donation = await _context.Donations.FindAsync(id);
        if (donation == null) return NotFound();
        return View(donation);
    }
}