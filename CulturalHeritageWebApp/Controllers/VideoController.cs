using AutoMapper;
using CulturalHeritageBL.DALModels;
using CulturalHeritageBL.Repositories;
using CulturalHeritageWebApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CulturalHeritageWebApp.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoRepository _videoRepo;
        private readonly IMapper _mapper;
        private readonly CulturalHeritageContext _dbContext;


        public VideoController(IVideoRepository videoRepo, IMapper mapper, CulturalHeritageContext dbContext)
        {
            _videoRepo = videoRepo;
            _mapper = mapper;
            _dbContext = dbContext;
        }


        // GET: VideoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VideoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VideoController/Create
        public ActionResult Create(int heritageID)
        {
            var viewModel = new VMVideo
            {
                HeritageId = heritageID
            };

            return View(viewModel);
        }

        // POST: VideoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Video video)
        {
            if (!ModelState.IsValid)
            {

                var viewModel = new VMVideo
                {
                    HeritageId = video.HeritageId
                };

                return View(viewModel);
            }

            _dbContext.Videos.Add(video);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }

        // GET: VideoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VideoController/Edit/5
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

        // GET: VideoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideoController/Delete/5
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
