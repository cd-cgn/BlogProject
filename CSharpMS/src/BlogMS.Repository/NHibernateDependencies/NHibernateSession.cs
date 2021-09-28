//using NHibernate;
//using NHibernate.Cfg;

//namespace BlogMS.Major.HbmModel
//{
//    public class NHibernateSession
//    {
        //public static ISession OpenSession()
       // {





    //        services.AddSingleton<Configuration>((provider) => {
    //            Configuration config = new Configuration();

    //            IDictionary<string, string> properties = new Dictionary<string, string> {
    //    { "connection.connection_string", this.Configuration.GetConnectionString("Default") },
    //    { "connection.driver_class", "MilestoneTG.NHibernate.TransientFaultHandling.SqlServer.SqlAzureClientDriver, MilestoneTG.NHibernate.TransientFaultHandling.SqlServer" },
    //    { "dialect", "NHibernate.Dialect.MsSql2012Dialect" },
    //    { "hbm2ddl.keywords", "auto-quote"},
    //    { "show_sql", "true"},
    //    { "generate_statistics", "true"}
    //};

    //            config.AddProperties(properties);
    //            config.AddXmlFile("hibernate.hbm.xml");
    //        });

    //        services.AddSingleton<ISessionFactory>((provider) => {
    //            return provider.GetService<Configuration>().BuildSessionFactory();
    //        });

    //        services.AddScoped<ISession>((provider) => {
    //            return provider.GetService<ISessionFactory>().OpenSession();
    //        });





























            //Configuration configuration = new Configuration();

            //configuration.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");

            //configuration.SetProperty("dialect", "NHibernate.Dialect.MsSql2012Dialect");

            //configuration.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver");

            //configuration.SetProperty("connection.connection_string", "Server=localhost;initial catalog=MyTestDB;Trusted_Connection=true;CharSet=utf8");

            ////configuration.SetProperty("proxyfactory.factory_class", "NHibernate.ByteCode.LinFu.ProxyFactoryFactory, NHibernate.ByteCode.LinFu");
            ////configuration.Configure();



            //var configuration = Fluently
            //.Configure()
            //.Database(persister)
            //.Mappings(map => map.FluentMappings.AddFromAssemblyOf<WordMap>())
            //.BuildConfiguration();

            //new SchemaExport(configuration).Execute(true, true, false);





            //configuration.AddAssembly(typeof(Blog).Assembly);



            //ISessionFactory sessionFactory = configuration.BuildSessionFactory();

            //return sessionFactory.OpenSession();

    //   // }
    //}
//}
