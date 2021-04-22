using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Widly.Controllers;
using Widly.Models;
using Widly.ViewModels;

namespace Widly.Controllers
{
    public class SongsService
    {
        #region DbContext
        
        private ApplicationDbContext _context;

        public SongsService()
        {
            _context = new ApplicationDbContext();
        }

        #endregion

        #region Services

        public void SaveSong(Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }

        public Song GetSong(int Id)
        {
            return _context.Songs.Find(Id);
        }

        public List<Song> GetSongs()
        {
           return _context.Songs.ToList();
        }

        public void UpdateSong(Song song)
        {
                _context.Entry(song).State = EntityState.Modified;
                _context.SaveChanges();
        }

        public void DeleteSong(int Id)
        {
            var song = _context.Songs.Find(Id);
            _context.Songs.Remove(song);
            _context.SaveChanges();
        }
        #endregion
    }

    public class SongsController : Controller
    {
        private SongsService songsService = new SongsService();

         SongsViewModel model = new SongsViewModel();
        // GET: Songs
        public ActionResult Index()
        {
            model.Songs = songsService.GetSongs();
            if (User.IsInRole(RoleName.CanManageMovies))
            {
                
                return View("List", model);
            }

            return View("ReadOnlyList", model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songsService.SaveSong(song);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var song = songsService.GetSong(Id);
            return PartialView(song);
        }
        [HttpPost]
        public ActionResult Edit(Song song)
        {
            songsService.UpdateSong(song);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            songsService.DeleteSong(Id);
            return RedirectToAction("Index");
        }
    }
}