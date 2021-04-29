using Microsoft.AspNetCore.Mvc;
using MedioSocial.core.Interfaces;
using System.Threading.Tasks;

namespace MedioSocial.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteRepositorio _estudianteRepositorio;
        public EstudianteController(IEstudianteRepositorio estudianteRepositorio)
        {
            _estudianteRepositorio = estudianteRepositorio;
        }

        [HttpGet]
        public async Task<IActionResult> GetEstudiantes()
        {
            var estudiante = await _estudianteRepositorio.GetEstudiantes();
            return Ok(estudiante);
        }
    }
}
