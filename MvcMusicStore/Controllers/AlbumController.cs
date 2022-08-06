using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{

   
    public class AlbumController : Controller
    {
        private readonly MvcMusicStoreContext _context;

        public AlbumController(MvcMusicStoreContext context)
        {
            _context = context;
        }



        // gets all album records on file and displays as a list
        public async Task<IActionResult> Index(Int32? artistId, string artistName)
        {
            if (artistId != null)
            {
                HttpContext.Session.SetString(nameof(artistId), artistId.ToString());
                HttpContext.Session.SetString(nameof(artistName), artistName);
            }
            else if (HttpContext.Session.GetString(nameof(artistId)) != null)
            {
                artistId = Convert.ToInt32(HttpContext.Session.GetString(nameof(artistId)));
                artistName = HttpContext.Session.GetString(nameof(artistName));
            }
            else
            {
                TempData["message"] = "please select an artist before looking for albums";
                return Redirect("/artist/index");
            }


            var albums = _context.Album.Where(a => a.ArtistId == artistId)
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .OrderBy(a => a.Title);
            return View(await albums.ToListAsync());
        }

        public enum BoatType { small, under17, over17, cruiser, catamaran }




        // GET: Album/Details/5
        public async Task<IActionResult> Details(Nullable<int> id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Album
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .FirstOrDefaultAsync(m => m.AlbumId == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // present an empty page to enter a new album
        public IActionResult Create()
        {
            ViewData["ArtistId"] = new
                SelectList(_context.Artist.OrderBy(a => a.Name), "ArtistId", "Name");
            ViewData["GenreId"] = new
                SelectList(_context.Genre.OrderBy(a => a.Name), "GenreId", "Name");
            return View();
        }

        // Post-back create: add the new album record to file if it passes edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(album);
                    await _context.SaveChangesAsync();
                    TempData["message"] = "new album added: " + album.Title;
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                ModelState.AddModelError("",
                    $"error adding new album: {ex.GetBaseException().Message}");
            }

            //ViewData["ArtistId"] = new SelectList(_context.Artist.OrderBy(a => a.Name), "ArtistId", "Name", album.ArtistId);
            //ViewData["GenreId"] = new SelectList(_context.Genre.OrderBy(a => a.Name), "GenreId", "Name", album.GenreId);
            Create();
            return View(album);
        }

        // GET: Album/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["message"] = "no key supplied for record to be updated";
                return Redirect("/album/index");
            }

            var album = await _context.Album.FindAsync(id);
            if (album == null)
            {
                TempData["message"] = "record key not found";
                return Redirect("/album/index");
            }
            //ViewData["ArtistId"] = new SelectList(_context.Artist, "ArtistId", "Name", album.ArtistId);
            //ViewData["GenreId"] = new SelectList(_context.Genre, "GenreId", "Name", album.GenreId);
            Create();
            return View(album);
        }

        // POST: Album/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Album album)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(album);
                    await _context.SaveChangesAsync();
                    TempData["message"] = $"album updated: {album.Title}";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("",
                        $"error applying the update: {ex.GetBaseException().Message}");
                }
            }
            //ViewData["ArtistId"] = new SelectList(_context.Artist.OrderBy(a => a.Name), "ArtistId", "Name", album.ArtistId);
            //ViewData["GenreId"] = new SelectList(_context.Genre.OrderBy(a => a.Name), "GenreId", "Name", album.GenreId);
            Create();
            return View(album);
        }

        // request confirm of selected album
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                TempData["message"] = "no key provided for album to be deleted";
                return RedirectToAction("index");
            }

            var album = await _context.Album
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .FirstOrDefaultAsync(m => m.AlbumId == id);
            if (album == null)
            {
                TempData["message"] = "album key not found";
                return RedirectToAction("index");
            }

            return View(album);
        }

        // delete confirmed record
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var album = await _context.Album.FindAsync(id);
                _context.Album.Remove(album);
                await _context.SaveChangesAsync();
                TempData["message"] = $"album deleted: {album.Title}";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["message"] = $"exception deleteing album: {ex.GetBaseException().Message}";
            }
            return Redirect("/album/delete/" + id);
        }

        // returns true if there is an album with the given ID
        private bool AlbumExists(int id)
        {
            return _context.Album.Any(e => e.AlbumId == id);
        }
    }
}
