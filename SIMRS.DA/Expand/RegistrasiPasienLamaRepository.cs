using SIMRS.DA.IRepository.IExpand;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SIMRS.DA.IRepository;
using System.Data;

namespace SIMRS.DA.Expand
{
    public class RegistrasiPasienLamaRepository : IRegistrasiPasienLamaRepository
    {
        private string sErrthrowClassName = "RegistrasiPasienLamaRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RegistrasiPasienLamaRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RegistrasiPasienLamaRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public async Task<(identitaspasien,alamatpasien, string)> GetIdentitaspasienAlamatpasienByNocmAsyn(string nocm)
        {
            identitaspasien IdentitasPasien;
            alamatpasien Alamatpasien;

            #region query

           
                _sql = "SELECT * FROM identitaspasien AS i WHERE i.nocm =  @nocm \n" +
                       "SELECT * FROM alamatpasien AS a WHERE a.nocm = @nocm";

            #endregion

            try
            {
                using (var multi = await _context.db.QueryMultipleAsync (_sql, new { nocm = nocm }, commandType: CommandType.Text))
                {
                    IdentitasPasien = await multi.ReadFirstOrDefaultAsync<identitaspasien>();
                    Alamatpasien = await multi.ReadFirstOrDefaultAsync<alamatpasien>();
                    
                }

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetIdentitaspasienAlamatpasienByNocmAsyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                IdentitasPasien = null; Alamatpasien = null;
            }

            return (IdentitasPasien, Alamatpasien, sErrResult);
        }
    }
}
