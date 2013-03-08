using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain
{
    public class Paciente
    {
        public virtual string Nome { get; set; }

        public virtual IList<Diagnostico> Diagnosticos { get; set; }

        public virtual int Id { get; set; }

        public Paciente() 
        {
            Diagnosticos = new List<Diagnostico>();
        }
    }
}
