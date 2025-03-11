using System.IdentityModel.Tokens.Jwt; // Para trabalhar com JWT
using System.Security.Claims;          // Para utilizar Claims
using Microsoft.IdentityModel.Tokens;  // Para trabalhar com SecurityKey e SigningCredentials
using System.Text;                     // Para Encoding
using apiToDo.DTO;
using apiToDo.Models;
using apiToDo.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

public class Usuario
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Name { get; set; }
    public string Job { get; set; }
}

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly string _secretKey = "uma_chave_secreta_muito_forte_e_longa_que_tem_mais_de_32_bytes";

    private readonly IPeopleService _peopleService;

    public AuthController(IPeopleService peopleService)
    {
        _peopleService = peopleService;
    }


    [HttpPost("login")]
    public ActionResult Login([FromBody] LoginDTO login)
    {
        try 
        {

            if (string.IsNullOrWhiteSpace(login.email) || string.IsNullOrWhiteSpace(login.password))
            {
               return BadRequest(new { msg = "Email ou senha incorretos. Verifique suas credenciais e tente novamente." });
            }

            PeopleModel peopleModel = _peopleService.FindOne(login.email);

            if (login.password == peopleModel.Password)
            {
                var token = GenerateToken(peopleModel);

                return Ok(new { token, name = peopleModel.Name, job = peopleModel.Job });
            }

            return StatusCode(401, new { message = "Email ou senha incorretos. Verifique suas credenciais e tente novamente." });

        }
        
        catch (Exception ex)
        {
            return StatusCode(400, new { message = "Email ou senha incorretos. Verifique suas credenciais e tente novamente." });
        }
    }

    private string GenerateToken(PeopleModel peopleModel)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, peopleModel.Phone.ToString()),
            new Claim(ClaimTypes.Name, peopleModel.Email)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: "apiToDo",
            audience: "apiToDo",
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
