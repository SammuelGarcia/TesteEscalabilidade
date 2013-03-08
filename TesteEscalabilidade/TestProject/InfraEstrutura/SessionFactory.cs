using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Mapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace TestProject.InfraEstrutura
{
    public class SessionFactory
    {

        public static ISessionFactory CreateSessionFactoryOracle()
        {
            return
                 Fluently.Configure()
            .ExposeConfiguration(c => c.SetProperty("current_session_context_class", "thread_static"))
            .Database(OracleClientConfiguration.Oracle10.ConnectionString(c => c
                .FromAppSetting("connectionOracle")
                )).Mappings(m => m.FluentMappings.AddFromAssemblyOf<PacienteMap>()).BuildSessionFactory();
        }

    }
}
