using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace FinTrackAPI.Config
{
    public class NHibernateHelper
    {
        private static ISessionFactory? _sessionFactory;
        private static readonly object _padlock = new object();

        public static ISessionFactory GetSessionFactory(string connectionString)
        {
            if (_sessionFactory != null) return _sessionFactory;

            lock (_padlock)
            {
                _sessionFactory = Fluently.Configure()
                    .Database(PostgreSQLConfiguration.PostgreSQL82
                        .ConnectionString(connectionString)
                        .Driver<NHibernate.Driver.NpgsqlDriver>())

                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>().Conventions.Add<SnakeCaseConvention>())
                    .ExposeConfiguration(cfg =>
                    {
                        new SchemaExport(cfg).Create(false, true);
                    })

                    .BuildSessionFactory();

                return _sessionFactory;
                }
            }
    }
}
