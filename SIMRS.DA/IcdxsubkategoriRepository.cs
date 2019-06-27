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
    public class IcdxsubkategoriRepository : IIcdxsubkategoriRepository
    {
        private string sErrthrowClassName = "IcdxsubkategoriRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public IcdxsubkategoriRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IcdxsubkategoriRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(icdxsubkategori obj)
        {
            throw new NotImplementedException();
        }

        public icdxsubkategori Get(icdxsubkategori obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<icdxsubkategori> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<icdxsubkategori>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<icdxsubkategori>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname)
        {
            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmeng FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmeng FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmeng) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";


            }
            #endregion

            IEnumerable<icdxsubkategori> list;

            try
            {
                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    list = await _context.db.QueryAsync<icdxsubkategori>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<icdxsubkategori>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllIcdxsubkategoriEngByPageIndexAndIcdxnameAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname)
        {

            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY;";
            }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmindo) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY;";



            }
            #endregion

            IEnumerable<icdxsubkategori> list;

            try
            {

                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    list = await _context.db.QueryAsync<icdxsubkategori>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<icdxsubkategori> (_sql, new { pageIndex = pageIndex, pageSize = pageSize, icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(icdxsubkategori, string)> GetAsync(icdxsubkategori obj)
        {
            throw new NotImplementedException();
        }

        public int Save(icdxsubkategori obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(icdxsubkategori obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriEngByIcdxnameAsync(string icdxname)
        {
            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmeng FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  ";
                   
            }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmeng FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmeng) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid ";
                   


            }
            #endregion

            IEnumerable<icdxsubkategori> list;

            try
            {
                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    list = await _context.db.QueryAsync<icdxsubkategori>(_sql, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<icdxsubkategori>(_sql, new { icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllIcdxsubkategoriEngByIcdxnameAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriIndoByIcdxnameAsync(string icdxname)
        {
            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  ";
            }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmindo) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  ";


            }
            #endregion

            IEnumerable<icdxsubkategori> list;

            try
            {
                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    list = await _context.db.QueryAsync<icdxsubkategori>(_sql,  commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<icdxsubkategori>(_sql, new { icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllIcdxsubkategoriIndoByIcdxnameAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<icdxsubkategori>, string) GetAllIcdxsubkategoriEngByIcdxname(string icdxname)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<icdxsubkategori>, string) GetAllIcdxsubkategoriIndoByIcdxname(string icdxname)
        {
            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid";
             }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmindo) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid";
            }
            #endregion

            IEnumerable<icdxsubkategori> list;

            try
            {


                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    list = _context.db.Query<icdxsubkategori>(_sql, commandType: CommandType.Text);
                }
                else
                {
                    list = _context.db.Query<icdxsubkategori>(_sql, new { icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllIcdxsubkategoriIndoByIcdxname";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<icdxsubkategori>, short, string) GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(int pageIndex, int pageSize, string icdxname)
        {
            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY; SELECT totalcount = count(*) from icdxsubkategori where icdxsubkategorists = '1'; ";
            }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmindo) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY; SELECT totalcount = count(*) from icdxsubkategori where icdxsubkategorists = '1';";



            }
            #endregion

            IEnumerable<icdxsubkategori> list;
            short totalcount =0;

            try
            {
                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    using (var multi = _context.db.QueryMultiple(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text))
                    {
                        list = multi.Read<icdxsubkategori>();
                        totalcount = multi.Read<short>().SingleOrDefault();
                    }
                }
                else
                {
                    using (var multi = _context.db.QueryMultiple(_sql, new { pageIndex = pageIndex, pageSize = pageSize, icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text))
                    {
                        list = multi.Read<icdxsubkategori>();
                        totalcount = multi.Read<short>().SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxname";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, totalcount, sErrResult);
        }

        public async Task<(IEnumerable<icdxsubkategori>, short, string)> GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname)
        {
            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY; SELECT totalcount = count(*) from icdxsubkategori where icdxsubkategorists = '1'; ";
            }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmindo FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmindo) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY; SELECT totalcount = count(*) from icdxsubkategori where icdxsubkategorists = '1';";



            }
            #endregion

            IEnumerable<icdxsubkategori> list;
            short totalcount = 0;

            try
            {
                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    using (var multi = await _context.db.QueryMultipleAsync(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text)) 
                    {
                        list = multi.Read<icdxsubkategori>();
                        totalcount = multi.Read<short>().SingleOrDefault();
                    }
                }
                else
                {
                    using (var multi = await _context.db.QueryMultipleAsync(_sql, new { pageIndex = pageIndex, pageSize = pageSize, icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text))
                    {
                        list = multi.Read<icdxsubkategori>();
                        totalcount = multi.Read<short>().SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxname";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, totalcount, sErrResult);
        }

        public async Task<(IEnumerable<icdxsubkategori>, short, string)> GetMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxname)
        {
            #region query

            if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmeng FROM icdxsubkategori AS i  \n"
                   + "WHERE i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY; SELECT totalcount = count(*) from icdxsubkategori where icdxsubkategorists = '1'; ";
            }
            else
            {
                _sql = "SELECT i.icdxsubkategoriid, i.icdxsubkategorinmeng FROM icdxsubkategori AS i  \n"
                   + "WHERE (i.icdxsubkategoriid+icdxsubkategorinmeng) LIKE @icdxname And i.icdxsubkategorists = '1' \n"
                   + "ORDER BY icdxsubkategoriid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY; SELECT totalcount = count(*) from icdxsubkategori where icdxsubkategorists = '1';";



            }
            #endregion

            IEnumerable<icdxsubkategori> list;
            short totalcount = 0;

            try
            {
                if ((icdxname == "") || (string.IsNullOrEmpty(icdxname)))
                {
                    using (var multi = await _context.db.QueryMultipleAsync(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text))
                    {
                        list = multi.Read<icdxsubkategori>();
                        totalcount = multi.Read<short>().SingleOrDefault();
                    }
                }
                else
                {
                    using (var multi = await _context.db.QueryMultipleAsync(_sql, new { pageIndex = pageIndex, pageSize = pageSize, icdxname = string.Format("%{0}%", icdxname) }, commandType: CommandType.Text))
                    {
                        list = multi.Read<icdxsubkategori>();
                        totalcount = multi.Read<short>().SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, totalcount, sErrResult);
        }
    }
}
