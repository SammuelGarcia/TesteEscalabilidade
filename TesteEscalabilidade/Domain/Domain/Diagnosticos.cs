using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain
{
    public class Diagnostico : IAggregateRoot<int>
    {
        public virtual string NomeDiagnostico { get; set; }

        public virtual int Id { get; set; }
    }
}
