using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain;
using FluentNHibernate.Mapping;

namespace Domain.Mapping
{
    public class DiagnosticoMap : ClassMap<Diagnostico>
    {
        public DiagnosticoMap() 
        {
            Id(d => d.Id);
            Map(d => d.NomeDiagnostico);
        }
    }
}
