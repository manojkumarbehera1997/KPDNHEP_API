using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;


namespace KPDNHEP.Console.Data.Repositories
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection connectionstring;
        //private readonly IConfigurationRoot Configuration;
        private readonly IConfiguration Configuration;

        public BaseRepository()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();

            Configuration = builder.Build();
            var constr = $"{Configuration["ConnectionStrings:DefaultConnection"]}";

            connectionstring = new MySql.Data.MySqlClient.MySqlConnection(constr);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
