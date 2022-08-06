using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly MvcMusicStoreContext _context;

        public OrderController(MvcMusicStoreContext context)
        {
            _context = context;
        }

        // GET: Order
        public async Task<IActionResult> Index()
        {
            var mvcMusicStoreContext = _context.Order.Include(o => o.CountryCodeNavigation).Include(o => o.ProvinceCodeNavigation);
            return View(await mvcMusicStoreContext.ToListAsync());
        }

        // GET: Order/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.CountryCodeNavigation)
                .Include(o => o.ProvinceCodeNavigation)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Order/Create
        public IActionResult Create()
        {
            Order order = new Order();
            order.OrderDate = DateTime.Now;
            ViewData["CountryCode"] = new SelectList(_context.Country.OrderBy(a => a.Name), "CountryCode", "Name");
            ViewData["ProvinceCode"] = new SelectList(_context.Province.OrderBy(a => a.Name), "ProvinceCode", "Name");
            return View(order);
        }



        // present form to upload a file
        public IActionResult Upload()
        {
            return View();
        }
        
        // read in uploaded file and copy its contents to a temporary file
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile uploadFile, string targetFileName)
        {
            string pathAndFile = @"c:\uploads\";

            if (uploadFile == null || uploadFile.Length == 0)
            {
                TempData["message"] = "file is empty or null";
                return View();
            }

            if (string.IsNullOrEmpty(targetFileName))
            {
                // get original file's name
                Int32 lastSlash = uploadFile.FileName.LastIndexOf(@"\");
                pathAndFile += uploadFile.FileName.Substring(lastSlash + 1);
            }
            else
                pathAndFile += targetFileName;

            try
            {     
                using (var stream = new FileStream(pathAndFile, FileMode.Create))
                {
                    await uploadFile.CopyToAsync(stream);
                }
                TempData["message"] = $"file '{uploadFile.FileName}' uploaded to '{pathAndFile}'";
            }
            catch (Exception ex)
            {
                TempData["message"] = $"exception on upload: {ex.GetBaseException().Message}";
            }
            return View();
        }




        // POST: Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,OrderDate,UserName,FirstName,LastName,Address,City,ProvinceCode,PostalCode,CountryCode,Phone,Email,Total")] Order order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(order);
                    await _context.SaveChangesAsync();
                    TempData["message"] = $"order added for {order.LastName}";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(
                    "", $"exception creating order: {ex.GetBaseException().Message}");
            }

            Create();
            return View(order);
        }

        // GET: Order/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["message"] = $"key is null ... try again";
                return RedirectToAction("Index");
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                TempData["message"] = $"record not found";
                return RedirectToAction("Index");
            }
            Create();
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,OrderDate,UserName,FirstName,LastName,Address,City,ProvinceCode,PostalCode,CountryCode,Phone,Email,Total")] Order order)
        {
            if (id != order.OrderId)
            {
                TempData["message"] = $"the key inside the record is not the one you asked for";
                return View(order);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                    TempData["message"] = "order updated";
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    TempData["message"] =
                        $"Exception thrown updating order: {ex.GetBaseException().Message}";
                }
            }
            Create();
            return View(order);
        }

        // display the select for confirming delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                TempData["message"] = "key to delete is empty";
                return RedirectToAction("index");
            }

            var order = await _context.Order
                .Include(o => o.CountryCodeNavigation)
                .Include(o => o.ProvinceCodeNavigation)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // delete confirmed ... delete record
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var order = await _context.Order.FindAsync(id);
                _context.Order.Remove(order);
                await _context.SaveChangesAsync();
                TempData["message"] = "delete worked";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["message"] = $"exception thrown deleting order: {ex.GetBaseException().Message}";
                return Redirect($"/Order/Delete{id}");
            }
            
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }
    }
}
