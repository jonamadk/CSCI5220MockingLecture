using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDbLib
{
    public interface IPersonRepository
    {
        Person Create(Person person);
    }
}
