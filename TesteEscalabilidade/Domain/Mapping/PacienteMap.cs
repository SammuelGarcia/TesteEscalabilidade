using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain;
using FluentNHibernate.Mapping;

namespace Domain.Mapping
{
    public class PacienteMap : ClassMap<Paciente>
    {
        public PacienteMap() 
        {
            Id(p => p.Id);
            Map(p => p.Nome);
            HasMany(p => p.Diagnosticos).Cascade.All();
        }
    }
}
