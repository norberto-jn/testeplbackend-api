using apiToDo.Models;
using apiToDo.Repository.Interface;
using System.Collections.Generic;
using apiToDo.DTO;
using System.Linq;

namespace apiToDo.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
    
        private static List<PeopleModel> listTask = new()
        {
            new PeopleModel
            {
                Email = "norberto@gmail.com",
                Password = "123",
                Name = "Norberto",
                Job = "Developer",
                Bio = "Test",
                Phone = "319999999"
            }
        };

        public List<PeopleModel> FindAll()
        {
            return listTask;
        }

        public PeopleModel FindOne(string email)
        {
            return listTask.FirstOrDefault(person => person.Email == email);
        }

        public void Save(PeopleDTO dto)
        {
            listTask.Add(new PeopleModel 
            { 
                Email = dto.email,
                Password = dto.password,
                Name = dto.name,
                Job =  dto.job,
                Bio = dto.bio,
                Phone = dto.phone
            });
        }

    }
}