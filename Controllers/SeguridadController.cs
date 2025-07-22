using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VoluntariosConectadosRD.Models;

namespace VoluntariosConectadosRD.Controllers
{
    public class SeguridadController : Controller
    {
        private readonly IConfiguration _configuration;

        public SeguridadController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Sin el [[Authorize]] podemos retornar un token predeterminado
        [HttpPost]
        [Route("/api/service/seguridad/Login")]

        // Por ahora, este Login no se llama, hasta que tengamos una conexión y buena validación con el Backend
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Reemplazar con la validación real del usuario
            if (model.Email == "admin@demo.com" && model.Password == "password123")
            {
                var token = GenerateJwtToken(model.Email);
                return Ok(new { token });
            }
            return Unauthorized("Credenciales inválidas");
        }

        private string GenerateJwtToken(string userEmail)
        {
            var jwtSettings = _configuration.GetSection("JWT");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"] ?? "your-very-strong-secret-key"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userEmail),
                new Claim(JwtRegisteredClaimNames.Email, userEmail),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Usando el tiempo de expiracion del JWT en minutos
            int expireMinutes = 60; // fallback
            if (int.TryParse(jwtSettings["Time"], out int parsedMinutes))
            {
                expireMinutes = parsedMinutes;
            }

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(expireMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [Authorize]
        public async Task<IActionResult> CambiarClave()
        {
            //TODO: Implementar la logica para cambiar la clave
            return Ok();
        }
    }
}
