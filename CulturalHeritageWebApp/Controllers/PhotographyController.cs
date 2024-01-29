using AutoMapper;
using CulturalHeritageBL.DALModels;
using CulturalHeritageBL.Repositories;
using CulturalHeritageWebApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace CulturalHeritageWebApp.Controllers
{
    public class PhotographyController : Controller
    {
        private readonly IPhotographyRepository _photoRepo;
        private readonly IMapper _mapper;
        private readonly CulturalHeritageContext _dbContext;


        public PhotographyController(IPhotographyRepository photoRepo, IMapper mapper, CulturalHeritageContext dbContext)
        {
            _photoRepo = photoRepo;
            _mapper = mapper;
            _dbContext = dbContext;
        }



        // GET: PhotographyController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhotographyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhotographyController/Create
        public ActionResult Create(int heritageID)
        {
            var viewModel = new VMPhotography
            {
                HeritageId = heritageID
            };

            return View(viewModel);
        }

        // POST: PhotographyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Photography photo)
        {
            if (!ModelState.IsValid)
            {

                var viewModel = new VMPhotography
                {
                    HeritageId = photo.HeritageId
                };

                return View(viewModel);
            }

            _dbContext.Photographies.Add(photo);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }

        // GET: PhotographyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhotographyController/Edit/5
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

        // GET: PhotographyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhotographyController/Delete/5
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
