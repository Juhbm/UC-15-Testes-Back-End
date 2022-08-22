using ChapterFST1.Interfaces;
using ChapterFST1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFST1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _iUsuarioRrepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _iUsuarioRrepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_iUsuarioRrepository.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Usuario usuarioEncontrado = _iUsuarioRrepository.BuscarPorId(id);

                if (usuarioEncontrado == null)
                    return NotFound();
              
                return Ok(usuarioEncontrado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]

        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                _iUsuarioRrepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]

        public IActionResult Alterar(int id, Usuario usuario)
        {
            try
            {
                _iUsuarioRrepository.Atualizar(id, usuario);

                return Ok("Usuario Alterado");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Deletar(int id)
        {
            try
            {
                _iUsuarioRrepository.Deletar(id);

                return Ok("Usuario Deletado!");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
