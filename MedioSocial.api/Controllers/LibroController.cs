using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MedioSocial.core.Interfaces;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroRepositorio _libroRepositorio;
        public LibroController(ILibroRepositorio libroRepositorio)
        {
            _libroRepositorio = libroRepositorio;
        }

        [HttpGet]
        public async Task<IActionResult> GetLibro()
        {
            var estudiante = await _libroRepositorio.GetLibro();
            return Ok(estudiante);
        }
    }
}
