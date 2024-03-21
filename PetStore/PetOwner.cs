using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.PetStore
{
    internal struct PetOwner
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal string Email { get; set; }
        internal IPet[] Pets { get; set; }

    }
}
