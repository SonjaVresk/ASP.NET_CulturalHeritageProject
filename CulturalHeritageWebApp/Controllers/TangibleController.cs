using AutoMapper;
using CulturalHeritageBL.BLModels;
using CulturalHeritageBL.DALModels;
using CulturalHeritageBL.Repositories;
using CulturalHeritageWebApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CulturalHeritageWebApp.Controllers
{
    public class TangibleController : Controller
    {
        private readonly IHeritageRepository _heritageRepo;
        private readonly IAgeCategoryRepository _ageCategoryRepo;
        private readonly IHeritageCategoryRepository _heritageCategoryRepo;
        private readonly IMapper _mapper;
        private readonly CulturalHeritageContext _dbContext;

        private const string tangible = "Tangible";

        public TangibleController(IHeritageRepository heritageRepo, IAgeCategoryRepository ageCategoryRepo, IHeritageCategoryRepository heritageCategoryRepo, IMapper mapper, CulturalHeritageContext dbContext)
        {
            _heritageRepo = heritageRepo;
            _ageCategoryRepo = ageCategoryRepo;
            _heritageCategoryRepo = heritageCategoryRepo;
            _mapper = mapper;
            _dbContext = dbContext;
        }


        // GET: TangibleController
        public ActionResult Index()
        {
            var blTangible = _heritageRepo.GetAllHeritage()
                .Where(a => a.HeritageCategory.Name == tangible);
            var vmTangible = _mapper.Map<IEnumerable<VMHeritage>>(blTangible);

            return View(vmTangible);
        }

        // GET: TangibleController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound("Heritage not found!");
            }

            var blHeritage = _heritageRepo.GetHeritage(id);
            var vmHeritage = _mapper.Map<VMHeritage>(blHeritage);

            if (vmHeritage == null)
            {
                return NotFound("Heritage not found!");
            }

            return View(vmHeritage);
        }

        // GET: TangibleController/Create
        public ActionResult Create()
        {
            var ageCategories = _ageCategoryRepo.GetAllAgeCategories().ToList();

            var ageCategoryList = new SelectList(ageCategories, "IDAgeCategory", "Name");


            var viewModel = new VMHeritage()
            {
                HeritageCategoryID = _heritageCategoryRepo.GetHeritageCategoryID(tangible),
                AgeCategoryList = ageCategoryList
            };

            return View(viewModel);
        }

        // POST: TangibleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Heritage heritage)
        {
            if (!ModelState.IsValid)
            {
                var ageCategories = _ageCategoryRepo.GetAllAgeCategories().ToList();

                var ageCategoryList = new SelectList(ageCategories, "IDAgeCategory", "Name");

                var viewModel = new VMHeritage()
                {
                    HeritageCategoryID = _heritageCategoryRepo.GetHeritageCategoryID(tangible),
                    AgeCategoryList = ageCategoryList
                };

                return View(viewModel);
            }

            _heritageRepo.AddHeritage(heritage);
            return RedirectToAction(nameof(Index));
        }

        // GET: TangibleController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var heritage = _heritageRepo.GetHeritage(id);
            if (heritage == null)
            {
                return BadRequest();
            }

            var ageCategories = _ageCategoryRepo.GetAllAgeCategories().ToList();
            var ageCategoryList = new SelectList(ageCategories, "IDAgeCategory", "Name");

            var viewModel = new VMHeritage()
            {
                IDHeritage = heritage.IDHeritage,
                Title = heritage.Title,
                Description = heritage.Description,
                HeritageCategoryID = heritage.HeritageCategoryId,
                AgeCategoryID = heritage.AgeCategoryId,
                AgeCategoryList = ageCategoryList
            };

            return View(viewModel);
        }

        // POST: TangibleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Heritage heritage)
        {
            if (ModelState.IsValid)
            {
                var tangible = _dbContext.Heritages.Find(heritage.IDHeritage);

                if (heritage == null)
                {
                    return BadRequest(ModelState);
                }

                tangible.Title = heritage.Title;
                tangible.Description = heritage.Description;
                tangible.HeritageCategoryId = heritage.HeritageCategoryId;
                tangible.AgeCategoryId = heritage.AgeCategoryId;

                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(heritage);
        }

        // GET: TangibleController/Delete/5
        public ActionResult Delete(int id)
        {
            var blHeritage = _heritageRepo.GetHeritage(id);
            var vmHeritage = _mapper.Map<VMHeritage>(blHeritage);
            return View(vmHeritage);
        }

        // POST: TangibleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, VMHeritage heritage)
        {
            var location = _heritageRepo.GetHeritage(id);
            if (heritage == null)
            {
                return NotFound();
            }

            var photosToDelete = _dbContext.Photographies.Where(p => p.HeritageId == id);

            _dbContext.Photographies.RemoveRange(photosToDelete);
            _dbContext.SaveChanges();

            var videoToDelete = _dbContext.Videos.Where(p => p.HeritageId == id);

            _dbContext.Videos.RemoveRange(videoToDelete);
            _dbContext.SaveChanges();

            var heritageToDelete = _dbContext.Heritages.Find(id);
            if (heritageToDelete != null)
            {
                _heritageRepo.DeleteHeritage(heritageToDelete);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
