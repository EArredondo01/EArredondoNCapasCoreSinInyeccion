using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class MateriaController : Controller
    {
        public IActionResult GetAll()
        {
            ML.Materia materia = new ML.Materia();
            ML.Result result = BL.Materia.GetAll();
            if (result.Correct)
            {
                materia.Materias = result.Objects;
            }
            return View(materia);
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
