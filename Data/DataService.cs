using CreateCRUDOperation.Context;
using Microsoft.EntityFrameworkCore;

namespace CreateCRUDOperation.Data
{
    public class DataService
    {
        private readonly Personcontext _personcontext;
        public DataService(Personcontext personcontext) 
        {
            _personcontext = personcontext;
        }

        public async Task<List<Person>> GetAllPersons()
        {
            return await _personcontext.Person.ToListAsync();
        }
        //Add new Data
        public async Task<bool> AddnewPerson(Person data)
        {
            await _personcontext.Person.AddAsync(data);
            await _personcontext.SaveChangesAsync();
            return true;
        }
        //ID
        public async Task<Person> GetPersonById(int id)
        {
            Person person = await _personcontext.Person.FirstOrDefaultAsync(x => x.Id == id);
            return person;
        }
        // Update
        public async Task<bool> UpdatePerson(Person person)
        {
            _personcontext.Person.Update(person);
            await _personcontext.SaveChangesAsync();
            return true;
        }
        //Delete
        public async Task<bool> DeletePerson(Person person)
        {
            _personcontext.Person.Remove(person);
            await _personcontext.SaveChangesAsync();
            return true;
        }
    }
}
