using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDbLib
{
    public class DbPersonRepository: IPersonRepository
    {
        private readonly PersonDbContext _db;
        public DbPersonRepository(PersonDbContext db)
        {
             _db = db;
        }

        public Person Create(Person person)
        {
            _db.People.Add(person);
            _db.SaveChanges();
            return person;
        }
    }

   
}
