using apiToDo.Models;
using apiToDo.Repository.Interface;
using apiToDo.Services.Interface;
using System.Collections.Generic;
using apiToDo.DTO;
using System;

namespace apiToDo.Services
{
    public class PeopleService : IPeopleService
    {

        private readonly IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public IList<PeopleModel> FindAll()
        {
            return _peopleRepository.FindAll();;
        }

        public PeopleModel FindOne(string email)
        {
            return _peopleRepository.FindOne(email) ?? throw new Exception($"Não foi possível encontrar uma pessoa com o email '{email}'. Verifique se o email está correto e tente novamente.");
        }

        public void Save(PeopleDTO dto)
        {
            try
            {
                _peopleRepository.Save(dto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro : {ex.Message}");
            }
        }

    }
}