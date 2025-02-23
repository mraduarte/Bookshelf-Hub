using bookshelfhub.Data;
using bookshelfhub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLoginApp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private static List<Login> users = new();

        // O DbContext é injetado no controlador através do construtor
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. Criação de um novo usuário
        [HttpPost("register")]
        public IActionResult CreateUser([FromBody] Login user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            // Criar o retorno com a rota correta para o recurso criado
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // 2. Autenticação de usuário
        [HttpPost("login")]
        public IActionResult Login([FromBody] Login user)
        {
            var existingUser = users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

            if (existingUser == null)
                return Unauthorized("Invalid username or password.");

            return Ok("Login successful.");
        }

        // 3. Obter usuário
        [HttpGet("getUser/{id}")]
        public IActionResult GetUser(string username)
        {
            var user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
                return NotFound("User not found.");

            return Ok(user);
        }

        // 4. Atualização de senha
        [HttpPut("updatePassword/{id}")]
        public IActionResult UpdatePassword(string username, [FromBody] string newPassword)
        {
            var user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
                return NotFound("User not found.");

            user.Password = newPassword;
            return Ok("Password updated successfully.");
        }

        // 5. Deletar usuário
        [HttpDelete("deleteUser/{id}")]
        public IActionResult DeleteUser(string username)
        {
            var user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
                return NotFound("User not found.");

            users.Remove(user);
            return Ok("User deleted successfully.");
        }
    }
}
