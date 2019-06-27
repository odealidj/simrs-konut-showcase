using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SIMRS.DA
{
    public class LoginmodulappRepository : ILoginmodulappRepository
    {
        private string sErrthrowClassName = "LoginmodulappRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public LoginmodulappRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public LoginmodulappRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(loginmodulapp obj)
        {
            throw new NotImplementedException();
        }

        public loginmodulapp Get(loginmodulapp obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<loginmodulapp> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<loginmodulapp>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public (loginmodulapp,string) getLoginmodulappByLoginappidAndModulappid(short loginappid, string modulappkode)
        {
            loginmodulapp loginapp = null;

            _sql = "SELECT * FROM loginmodulapp AS l \n"
                + "WHERE l.loginappid = @loginappid AND l.modulappkode = @modulappkode \n"
                + "AND l.loginmodulappsts = '1'";
            try
            {
                loginapp = _context.db.Query<loginmodulapp>(_sql, new { loginappid = loginappid, modulappkode = modulappkode }, commandType: CommandType.Text).FirstOrDefault();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "getLoginmodulappByLoginappid";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (loginapp,sErrResult);
        }

        public int Save(loginmodulapp obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(loginmodulapp obj)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<loginmodulapp>,string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(loginmodulapp, string)> GetAsync(loginmodulapp obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(loginappdetail, loginmodulapp, string)> GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkodeAsync(string username, string password, string modulappkode)
        {
              
                loginappdetail loginappDetail = null;
                loginmodulapp loginModulapp = null;

                #region query

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(modulappkode))
                {
                _sql = "SELECT l2.loginappdetailid,l2.loginappdetailnik,l2.loginappdetailnm \n"
                   + "FROM loginapp AS l INNER JOIN loginappdetail AS l2 ON l2.loginappdetailid = l.loginappid \n"
                   + "WHERE l.loginappuser = @username AND l.loginapppasswd = @password and l.loginappsts = '1' AND l2.sts = '1'; \n"
                   + "SELECT l.loginmodulappid,l.modulappkode,l.loginappid  FROM loginmodulapp AS l \n"
                   + "WHERE l.modulappkode = @modulappkode AND l.loginmodulappsts = '1' ";
                }
                #endregion

                try
                {
                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(modulappkode))
                    {
                        using (var multi = await _context.db.QueryMultipleAsync(_sql, new { username = username, password = password, modulappkode = modulappkode }, commandType: CommandType.Text))
                        {
                            loginappDetail = multi.Read<loginappdetail>().FirstOrDefault();
                            loginModulapp = multi.Read<loginmodulapp>().FirstOrDefault();
                        }
                    }
                }
                catch (Exception ex)
                {
                    sErrthrowMethodName = "GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkode";
                    sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                    loginappDetail = null; loginModulapp = null;
                }

                return (loginappDetail, loginModulapp, sErrResult);
        }

        public (loginappdetail, loginmodulapp, string) GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkode(string username, string password, string modulappkode)
        {
            loginappdetail loginappDetail = null;
            loginmodulapp loginModulapp = null;

            #region query

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(modulappkode))
            {
                _sql = "SELECT l2.loginappdetailid,l2.loginappdetailnik,l2.loginappdetailnm \n"
                   + "FROM loginapp AS l INNER JOIN loginappdetail AS l2 ON l2.loginappdetailid = l.loginappid \n"
                   + "WHERE l.loginappuser = @username AND l.loginapppasswd = @password and l.loginappsts = '1' AND l2.sts = '1' \n"
                   + "SELECT l.loginmodulappid,l.modulappkode,l.loginappid  FROM loginmodulapp AS l \n"
                   + "WHERE l.modulappkode = @modulappkode AND l.loginmodulappsts = '1' ";
            }
            #endregion

            try
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(modulappkode))
                {
                    using (var multi = _context.db.QueryMultiple(_sql, new { username = username, password = password, modulappkode = modulappkode }, commandType: CommandType.Text))
                    {
                        loginappDetail = multi.Read<loginappdetail>().FirstOrDefault();
                        loginModulapp = multi.Read<loginmodulapp>().FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetLoginappdetailAndLoginmodulappByUsernamePasswordModulappkode";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                loginappDetail = null; loginModulapp = null;
            }

            return (loginappDetail, loginModulapp, sErrResult);
        }
    }
}
