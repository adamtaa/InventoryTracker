using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace InventoryTracker.Utility.Factories
{
    public class DbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        private readonly IHttpContextAccessor _ihttpContextAccessor;
        public DbConnectionFactory()
        {
        }

        public DbConnectionFactory(IConfiguration configuration, IHttpContextAccessor ihttpContextAccessor)
        {
            _configuration = configuration;
            _ihttpContextAccessor = ihttpContextAccessor;
        }

        public SqlConnection GetSqlConnection(string connectionStringName)
        {
            var connectionString = GetConnectionString(connectionStringName);

            return new SqlConnection(connectionString);
        }

        public string GetConnectionString(string connectionStringName)
        {
            var connectionString = _configuration.GetConnectionString(connectionStringName);

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ConfigurationErrorsException(@"The connection string key entry " + connectionStringName + " cannot be found");
            }

            StringBuilder connectionStringBuilder = new StringBuilder().AppendFormat(connectionString);

            return connectionStringBuilder.ToString();
        }
    }
}
