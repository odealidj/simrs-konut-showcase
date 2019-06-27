using Dapper;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA
{
    public class AlamatpasienRepository : IAlamatpasienRepository
    {
        private string sErrthrowClassName = "AlamatpasienRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AlamatpasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AlamatpasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(alamatpasien obj)
        {
            throw new NotImplementedException();
        }

        public alamatpasien Get(alamatpasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<alamatpasien> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<alamatpasien>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<alamatpasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(alamatpasien, string)> GetAsync(alamatpasien obj)
        {
            throw new NotImplementedException();
        }

        public string Save(alamatpasien obj)
        {
            var result = 0;
           

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("alamatpasienid", obj.alamatpasienid);
                p.Add("nocm", obj.nocm);
                p.Add("alamat", obj.alamat);
                p.Add("kodepos", obj.kodepos);
                p.Add("kotakabid", (obj.kotakabid == -1) ? null : obj.kotakabid);
                p.Add("kecid", (obj.kecid == -1) ? null : obj.kecid);
                p.Add("keldesaid", (obj.keldesaid == -1) ? null : obj.keldesaid);
                p.Add("rwid", (obj.rwid == -1) ? null : obj.rwid);
                p.Add("rtid", (obj.rtid == -1) ? null : obj.rtid);
                p.Add("alamatpasiensts", obj.alamatpasiensts);
                

                _sql = @"p_Savealamatpasien"; 


                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                
            }

            return sErrResult;
        }

        public bool Update(alamatpasien obj)
        {
            throw new NotImplementedException();
        }

        int IBaseRepository<alamatpasien>.Save(alamatpasien obj)
        {
            throw new NotImplementedException();
        }
    }
}
