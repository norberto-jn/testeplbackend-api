using apiToDo.Models;
using System.Collections.Generic;
using apiToDo.DTO;

namespace apiToDo.Services.Interface
{
    public interface IPeopleService
    {
        public void Save(PeopleDTO Dto);
        public IList<PeopleModel> FindAll();
        public PeopleModel FindOne(string Email);
    }
}