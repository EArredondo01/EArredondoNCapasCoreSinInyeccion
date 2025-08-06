using Microsoft.EntityFrameworkCore;

namespace BL
{
    public class Materia
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.EarredondoProgramacionNcapasJunioContext context = new DL.EarredondoProgramacionNcapasJunioContext())
                {
                    // conexion, en donde voy a guardar la informacion , ejecutar el SP4

                    var query = context.MateriaGetAllDTO.FromSqlRaw("MateriaGetAll").ToList(); // lista con 2 materias  

                    // FromSqlRaw - SELECT

                    // ExecuteSqlRaw   -INSERT UPDATE Y DELETE 

                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var materiaDB in query)
                        {
                            ML.Materia materia = new ML.Materia();
                            materia.Semestre = new ML.Semestre();

                            materia.IdMateria = materiaDB.IdMateria;
                            materia.Nombre = materiaDB.NombreMateria;
                            materia.Creditos = materiaDB.Creditos;
                            materia.Costo = materiaDB.Costo;
                            materia.Semestre.IdSemestre = materiaDB.IdSemestre;
                            materia.Semestre.Nombre = materiaDB.NombreSemestre;

                            result.Objects.Add(materia);                      
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }


                }

            } catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetAllSemestre()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.EarredondoProgramacionNcapasJunioContext context = new DL.EarredondoProgramacionNcapasJunioContext())
                {
                    // conexion, en donde voy a guardar la informacion , ejecutar el SP4

                    var query = context.Semestres.ToList(); // lista con 2 materias  

                    // FromSqlRaw - SELECT

                    // ExecuteSqlRaw   -INSERT UPDATE Y DELETE 

                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var semestreDB in query)
                        {
                            ML.Semestre semestre = new ML.Semestre();

                            semestre.IdSemestre = semestreDB.IdSemestre;
                            semestre.Nombre = semestreDB.Nombre;

                            result.Objects.Add(semestre);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }


                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
