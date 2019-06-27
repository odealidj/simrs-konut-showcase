using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SIMRS.DA
{
    public class IcdxkategoriRepository : IIcdxkategoriRepository
    {

        private string sErrthrowClassName = "IcdxkategoriRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public IcdxkategoriRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IcdxkategoriRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(icdxkategori obj)
        {
            throw new NotImplementedException();
        }

        public icdxkategori Get(icdxkategori obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<icdxkategori> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<icdxkategori>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<icdxkategori>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<vicdxsubkategori>, string)> GetAllVicdxsubkategoriByPageIndexAndConcateAsync(int pageIndex, int pageSize,  string icdxsubkategoriconcate)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<vicdxsubkategorieng>, string)> GetAllVicdxsubkategoriEngByPageIndexAndConcateAsync(int pageIndex, int pageSize,  string icdxsubkategoriconcate)
        {
            #region query

            if ((icdxsubkategoriconcate == "") || (string.IsNullOrEmpty(icdxsubkategoriconcate)))
            {
                _sql = "SELECT * FROM vicdxsubkategorieng \n"
                    + "ORDER BY icdxsubkategoriid \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            }
            else
            {
                _sql = "SELECT * FROM vicdxsubkategorieng \n"
                    + "WHERE fieldconcate LIKE fieldconcate \n"
                    + "ORDER BY icdxsubkategoriid \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }
            #endregion

            IEnumerable<vicdxsubkategorieng> list;

            try
            {
                if ((icdxsubkategoriconcate == "") || (string.IsNullOrEmpty(icdxsubkategoriconcate)))
                {
                    list = await _context.db.QueryAsync<vicdxsubkategorieng>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<vicdxsubkategorieng>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, fieldconcate = string.Format("%{0}%", icdxsubkategoriconcate) }, commandType: CommandType.Text);
                }
                    
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVicdxsubkategoriEngByPageIndexAndConcate";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<vicdxsubkategoriindo>, string)> GetAllVicdxsubkategoriIndoByPageIndexAndConcateAsync(int pageIndex, int pageSize, string icdxsubkategoriconcate)
        {

            #region query

            if ((icdxsubkategoriconcate == "") || (string.IsNullOrEmpty(icdxsubkategoriconcate)))
            {
                _sql = "SELECT * FROM vicdxsubkategoriindo \n"
                + "ORDER BY icdxsubkategoriid \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";
            }
            else
            {
                _sql = "SELECT * FROM vicdxsubkategoriindo \n"
                + "WHERE fieldconcate LIKE fieldconcate \n"
                + "ORDER BY icdxsubkategoriid \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";

            }
            #endregion

            IEnumerable<vicdxsubkategoriindo> list;

            try
            {
                if ((icdxsubkategoriconcate == "") || (string.IsNullOrEmpty(icdxsubkategoriconcate)))
                {
                    list = await _context.db.QueryAsync<vicdxsubkategoriindo>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<vicdxsubkategoriindo>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, fieldconcate = string.Format("%{0}%", icdxsubkategoriconcate) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVicdxsubkategoriIndoByPageIndexAndConcate";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(icdxkategori, string)> GetAsync(icdxkategori obj)
        {
            throw new NotImplementedException();
        }

        public int Save(icdxkategori obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(icdxkategori obj)
        {
            throw new NotImplementedException();
        }
    }
}
