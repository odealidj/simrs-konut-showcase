using SIMRS.DA.IRepository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class DapperContext : IDapperContext
    {
        private static string _providerName;// = "System.Data.SqlClient";
        private static string _connectionString;// = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private IDbConnection _db = null;

        //private Task<IDbConnection> _db1;

        //private Task<DbConnection> conn1;

        private static DbConnection conn = null;

        public DapperContext()
        {
            //var dbName = System.IO.Directory.GetCurrentDirectory() + "\\Northwind.db";

            _providerName = "System.Data.SqlClient";
            //_connectionString = @"Server=.\\SQLEXPRESS;Initial Catalog=simrs;User ID=sa;Integrated Security=True;";
            _connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            //GetOpenConnection("","");
        }

        public DapperContext(IDbConnection db)
        {
            _db = db;
        }

        private IDbConnection GetOpenConnection(string providerName, string connectionString)
        {
            

            try
            {
                DbProviderFactory provider = DbProviderFactories.GetFactory(providerName);
                //DbProviderFactory provider = HelperDbProviderFactory.GetDbProviderFactory(providerName);

                conn = provider.CreateConnection();
                //conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return conn;
        }

        public IDbConnection db
        {
            get { return _db ?? (_db = GetOpenConnection(_providerName, _connectionString)); }

            //get { return this._db; }
        }


        private async Task<IDbConnection> GetOpenConnectionAsync(string providerName, string connectionString)
        {


            try
            {
                DbProviderFactory provider = DbProviderFactories.GetFactory(providerName);
                //DbProviderFactory provider = HelperDbProviderFactory.GetDbProviderFactory(providerName);

                conn = provider.CreateConnection();
                //conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                await conn.OpenAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return conn;
        }

        public IDbConnection dbAsync
        {
            

            get { return _db ?? (_db =  GetOpenConnectionAsync(_providerName, _connectionString).Result ); }

            //get { return this._db; }
        }



        public int GetLastId()
        {
            var lastId = 0;

            try
            {
                var sql = @"SELECT LAST_INSERT_ROWID()";
                lastId = _db.ExecuteScalar<int>(sql);
            }
            catch
            {
            }

            return lastId;
        }

        public void Dispose()
        {
            if (_db != null)
            {
                try
                {
                    if (_db.State != ConnectionState.Closed)
                        _db.Close();
                }
                finally
                {
                    
                    _db.Dispose();
                    //_db = null;

                }
            }

            GC.SuppressFinalize(this);
        }



    }
}
