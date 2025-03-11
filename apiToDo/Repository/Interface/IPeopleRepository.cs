using apiToDo.Models;
using System.Collections.Generic;
using apiToDo.DTO;

namespace apiToDo.Repository.Interface
{
    public interface IPeopleRepository
    {
        public List<PeopleModel> FindAll();
        public PeopleModel FindOne(string Email);
        public void Save(PeopleDTO Dto);
    }
}