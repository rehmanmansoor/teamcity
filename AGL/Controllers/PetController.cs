using AGL.Business;
using System.Web.Mvc;

namespace AGL.Controllers
{
  public class PetController : Controller
    {
    readonly ICatService _catService;
    public PetController(ICatService services)
    {
      _catService = services;
    }


    // GET: Pet
    public ActionResult Index()
    {
      var cats = _catService.GetCatsByOwnerGender();

      return View(cats);

    }

       
    }
}
