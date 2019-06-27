using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class LoginappRepository : ILoginappRepository
    {

        private string sErrthrowClassName = "LoginappRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public LoginappRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public LoginappRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(loginapp obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<loginapp> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<loginapp>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public loginapp getLoginappByUsernameAndPassword(string username, string password)
        {
            //IList<v_tf2tka_tnegara> list;

            loginapp loginapp = null;

            _sql = "SELECT l.loginappid \n"
                       + "FROM loginapp AS l INNER JOIN loginappdetail AS l2 ON l2.loginappdetailid = l.loginappid \n"
                       + "WHERE l.loginappuser = @username AND l.loginapppasswd = @password and l.loginappsts = '1'";
            try
            {
                loginapp = _context.db.Query<loginapp>(_sql, new { username = username, password = password }, commandType: CommandType.Text).FirstOrDefault();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "getLoginappByUsernameAndPassword";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                
            }

            return loginapp;
        }

        public int Save(loginapp obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(loginapp obj)
        {
            throw new NotImplementedException();
        }

        public loginapp Get(loginapp obj)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<loginapp>,string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(loginapp, string)> GetAsync(loginapp obj)
        {
            throw new NotImplementedException();
        }
    }
}
