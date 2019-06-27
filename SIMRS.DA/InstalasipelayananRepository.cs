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
    public class InstalasipelayananRepository : IInstalasipelayananRepository
    {

        private string sErrthrowClassName = "InstalasipelayananRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public InstalasipelayananRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public InstalasipelayananRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(Instalasipelayanan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instalasipelayanan> GetAll()
        {
            IEnumerable<Instalasipelayanan> list;

            _sql = "SELECT * FROM instalasipelayanan AS i;";

            try
            {
                list = _context.db.Query<Instalasipelayanan>(_sql, commandType: CommandType.Text).ToList();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public async Task<IEnumerable<Instalasipelayanan>> GetAllInstalasipelayananByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllInstalasiPelayanan";
            var param = new DynamicParameters();
            param.Add("@RowsPerPage", pageSize);
            param.Add("@PageNumber", pageIndex);

            var list = await _context.db.QueryAsync<Instalasipelayanan>(query, param, commandType: CommandType.StoredProcedure);
            return list;

        }

       

        public int Save(Instalasipelayanan obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Instalasipelayanan obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Instalasipelayanan>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Instalasipelayanan Get(Instalasipelayanan obj)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<Instalasipelayanan>,string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(Instalasipelayanan, string)> GetAsync(Instalasipelayanan obj)
        {
            throw new NotImplementedException();
        }
    }
}
