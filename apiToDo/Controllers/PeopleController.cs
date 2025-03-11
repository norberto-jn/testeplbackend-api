using apiToDo.DTO;
using apiToDo.Models;
using apiToDo.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace apiToDo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {

        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpPost]
        public ActionResult Save([FromBody] PeopleDTO dto)
        {
            try
            {
                var campos = new Dictionary<string, string>
                {
                    { "nome", dto.name },
                    { "email", dto.email },
                    { "senha", dto.password },
                    { "biografia", dto.bio },
                    { "telefone", dto.phone },
                    { "profissão", dto.job }
                };

                foreach (var campo in campos)
                {
                    if (string.IsNullOrWhiteSpace(campo.Value))
                    {
                        return BadRequest(new { message = $"O campo {campo.Key} não pode ser vazio ou conter apenas espaços em branco. Por favor, forneça um {campo.Key} válido(a)." });
                    }
                }

                _peopleService.Save(dto);


                return Ok(new { message = "Pessoa inserida com sucesso."});
            }

            catch (Exception ex)
            {
                return StatusCode(400, new { message = $"Ocorreu um erro em sua API {ex.Message}" });
            }
        }

    }
}
