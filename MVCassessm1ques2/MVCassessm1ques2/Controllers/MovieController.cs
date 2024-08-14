﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
MVCassessm1ques2.Models; 
using System.Linq;
using System.Threading.Tasks;

public class MovieController : Controller
{
    private readonly MoviesDbContext _context;

    public MovieController(MoviesDbContext context)
    {
        _context = context;
    }

    // GET: Movie
    public async Task<IActionResult> Index()
    {
        return View(await _context.Movies.ToListAsync());
    }

    // GET: Movie/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Movie/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Mid,Moviename,DateofRelease")] Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(movie);
    }

    // GET: Movie/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var movie = await _context.Movies.FindAsync(id);
        if (movie == null)
        {
            return NotFound();
        }
        return View(movie);
    }

    // POST: Movie/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Mid,Moviename,DateofRelease")] Movie movie)
    {
        if (id != movie.Mid)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(movie);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(movie.Mid))
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
        return View(movie);
    }

    // GET: Movie/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var movie = await _context.Movies
            .FirstOrDefaultAsync(m => m.Mid == id);
        if (movie == null)
        {
            return NotFound();
        }

        return View(movie);
    }

    // POST: Movie/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var movie = await _context.Movies.FindAsync(id);
        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool MovieExists(int id)
    {
        return _context.Movies.Any(e => e.Mid == id);
    }

    // GET: Movie/ByYear/2024
    public async Task<IActionResult> ByYear(int year)
    {
        var movies = await _context.Movies
                                   .Where(m => m.DateofRelease.Year == year)
                                   .ToListAsync();
        return View(movies);
    }
}
