using Microsoft.AspNetCore.Mvc;
using MedioSocial.infraestructura.Repositorios;
using MedioSocial.core.Interfaces;
using System.Threading.Tasks;

namespace MedioSocial.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class postController : ControllerBase
    {
        private readonly IPostRepositorio _postRepositorio;
        public postController(IPostRepositorio  PostRepositorio) 
        {
            _postRepositorio = PostRepositorio;
        }
            
        [HttpGet]
        public async Task<IActionResult> getPosts()
        {
            var posts = await _postRepositorio.GetPosts();
            return Ok(posts);
        }
    }
}
