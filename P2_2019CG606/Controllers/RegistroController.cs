using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2019CG606.Models;

namespace P2_2019CG606.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Index()
        {
            var listaDepartamentos = (from m in _registroCovidContext.departamentos
                                 select m).ToList();
            ViewData["listadoDepartamentos"] = new SelectList(listaDepartamentos, "id_departamentos", "nombre");

            var listaDeGeneros = (from m in _registroCovidContext.generos
                                      select m).ToList();
            ViewData["listadoDeGeneros"] = new SelectList(listaDeGeneros, "id_genero", "genero");

            var listadoDeRegistro = (from c in _registroCovidContext.casos_reportado
                                   join d in _registroCovidContext.departamentos on c.departamentos_id equals d.id_departamentos
                                   join g in _registroCovidContext.generos on c.genero_id equals g.id_genero
                                   select new
                                   {
                                       departamento = d.nombre,
                                       genero = g.genero,
                                       confirmados = c.casos_confirmados,
                                       recuperados = c.casos_recuperado,
                                       fallecidos = c.casos_fallecidos
                                   }).ToList();
            ViewData["listadoRegistro"] = listadoDeRegistro;
                                  
            return View();
        }

        private registroCovidContext _registroCovidContext;
        public RegistroController(registroCovidContext registroCovidContext)
        {
            _registroCovidContext = registroCovidContext;
        }
        public IActionResult CrearCasos(casos_reportado nuevo_caso)
        {
            _registroCovidContext.Add(nuevo_caso);
            _registroCovidContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
