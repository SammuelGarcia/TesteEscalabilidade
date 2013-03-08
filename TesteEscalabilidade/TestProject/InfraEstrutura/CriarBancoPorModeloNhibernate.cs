using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Mapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace TestProject.InfraEstrutura
{
    [TestFixture]
    public class CriarBancoDeDadosPorModeloNhibernate
    {
        [Test]
        public void a_Criar_Banco_De_Dados_Por_Modelo()
        {
            try
            {

                Fluently.Configure()
          .Database(OracleClientConfiguration.Oracle10.ConnectionString(c => c
              .FromAppSetting("connectionOracle")
              ).ShowSql()).Mappings(m => m.FluentMappings.AddFromAssemblyOf<PacienteMap>()).Mappings(m => m.MergeMappings())
                .ExposeConfiguration(BuildSchema).BuildSessionFactory();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BuildSchema(NHibernate.Cfg.Configuration config)
        {
            new SchemaExport(config)
                 .Drop(true, true);

            new SchemaExport(config)
                .Create(true, true);
        }

    }
}
