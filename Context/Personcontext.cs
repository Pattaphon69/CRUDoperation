using CreateCRUDOperation.Data;
using Microsoft.EntityFrameworkCore;

namespace CreateCRUDOperation.Context
{
    public class Personcontext :DbContext
    {
        public Personcontext(DbContextOptions<Personcontext> options) 
            :base(options)
        { 

        }

        public DbSet<Person> Person { get; set; }
    }
}
