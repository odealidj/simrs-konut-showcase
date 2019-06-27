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
    public class LoginappdetailRepository : ILoginappdetailRepository
    {
        private string sErrthrowClassName = "LoginappdetailRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public LoginappdetailRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public LoginappdetailRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(loginappdetail obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<loginappdetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<loginappdetail>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(loginappdetail obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(loginappdetail obj)
        {
            throw new NotImplementedException();
        }

        public loginappdetail Get(loginappdetail obj)
        {
            loginappdetail loginapp = null;

            _sql = "SELECT * FROM loginappdetail AS l \n"
           + "WHERE l.loginappdetailid = @loginappdetailid ";

            //_sql = "SELECT l.loginappid \n"
            //           + "FROM loginapp AS l INNER JOIN loginappdetail AS l2 ON l2.loginappdetailid = l.loginappid \n"
            //           + "WHERE l.loginappuser = @username AND l.loginapppasswd = @password and l.loginappsts = '1'";
            try
            {
                loginapp = _context.db.Query<loginappdetail>(_sql, new { loginappdetailid = obj.loginappdetailid }, commandType: CommandType.Text).FirstOrDefault();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Get";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return loginapp;
        }

        public Task<(IEnumerable<loginappdetail>,string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(loginappdetail, string)> GetAsync(loginappdetail obj)
        {
            throw new NotImplementedException();
        }



        
    }
}
