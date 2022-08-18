using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusicStore.Controllers
{
    public class BlobsController : Controller
    {
        // GET: BlobsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlobsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlobsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlobsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlobsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlobsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlobsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlobsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
