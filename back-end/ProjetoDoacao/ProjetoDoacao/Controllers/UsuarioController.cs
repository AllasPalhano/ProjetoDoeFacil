using Microsoft.AspNetCore.Mvc;
using ApiGeral.Classe;
using ProjetoDoacao.Repositorio;
using BCrypt.Net;

namespace ProjetoDoacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest(new { mensagem = "Dados do usuário inválidos." });

            // Hashear a senha antes de salvar
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            var resultado = _usuarioRepositorio.Inserir(usuario);

            if (resultado == "Usuário inserido com sucesso!")
                return Ok(new { mensagem = resultado });

            return BadRequest(new { mensagem = resultado });
        }

        [HttpGet("buscar/{id}")]
        public IActionResult BuscarPorId(long id)
        {
            var usuario = _usuarioRepositorio.BuscarPorId(id);

            if (usuario == null)
                return NotFound(new { mensagem = "Usuário não encontrado." });

            return Ok(usuario);
        }

        [HttpGet("listar")]
        public IActionResult ListarTodos()
        {
            var usuarios = _usuarioRepositorio.Listar();
            return Ok(usuarios);
        }

        [HttpPut("atualizar/{id}")]
        public IActionResult Atualizar(long id, [FromBody] Usuario usuario)
        {
            var usuarioExistente = _usuarioRepositorio.BuscarPorId(id);
            if (usuarioExistente == null)
                return NotFound(new { mensagem = "Usuário não encontrado." });

            usuario.IdUsuario = id;

            // Hashear a nova senha se ela foi alterada
            if (!string.IsNullOrEmpty(usuario.Senha))
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            }

            var resultado = _usuarioRepositorio.Atualizar(usuario);
            return Ok(new { mensagem = resultado });
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Excluir(long id)
        {
            var usuarioExistente = _usuarioRepositorio.BuscarPorId(id);
            if (usuarioExistente == null)
                return NotFound(new { mensagem = "Usuário não encontrado." });

            var resultado = _usuarioRepositorio.Excluir(id);
            return Ok(new { mensagem = resultado });
        }
    }
}
