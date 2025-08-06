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
            ML.Materia materia = new ML.Materia();
            materia.Semestre = new ML.Semestre();

            ML.Result result = BL.Materia.GetAllSemestre();
            if (result.Correct)
            {
                materia.Semestre.Semestres = result.Objects;
            }

            return View(materia);
        }
    }
}
