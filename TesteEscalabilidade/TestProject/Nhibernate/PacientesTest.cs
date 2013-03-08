using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Domain.Domain;
using Domain.RepositoryNhibernate;
using FizzWare.NBuilder;
using NUnit.Framework;

namespace TestProject.Nhibernate
{
    [TestFixture]
    public class PacientesTest
    {
        [Test]
        public void CriarPacientes() 
        {
            var pacientes = Builder<Paciente>
                .CreateListOfSize(99999)
                .All()
                .With(p => p.Id = 0)
                .With(p=> p.Diagnosticos =  Builder<Diagnostico>
                    .CreateListOfSize(10)
                    .All()
                    .With(d=> d.Id = 0)
                    .Build()
                    )
                .Build();

            Pacientes repositorio = new Pacientes();

            Timer timer = new Timer();
            timer.Start();

            repositorio.SalvarLista(pacientes);
            timer.Stop();

            var intervalo = timer.Interval;

        }

    }
}
