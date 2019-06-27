using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class PelayananpasienpelunasanRepository : IPelayananpasienpelunasanRepository
    {
        private string sErrthrowClassName = "PelayananpasienpelunasanRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PelayananpasienpelunasanRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PelayananpasienpelunasanRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(pelayananpasienpelunasan obj)
        {
            throw new NotImplementedException();
        }

        public pelayananpasienpelunasan Get(pelayananpasienpelunasan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pelayananpasienpelunasan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<pelayananpasienpelunasan>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<pelayananpasienpelunasan>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_registrasi_transaksi>, string)> GetAllVregistrasitransaksiByPageIndexAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT * FROM v_registrasi_transaksi \n"
                        + "ORDER BY registrasiid DESC"
                        + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                        + "FETCH NEXT @pageSize ROWS ONLY";
            }
            else
            {
                _sql = "SELECT * FROM v_registrasi_transaksi \n"
                        + "WHERE nocm+nama+noregistrasi LIKE @value"
                        + "ORDER BY registrasiid DESC"
                        + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                        + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_registrasi_transaksi> list = null;

            try
            {
                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasi_transaksi>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasi_transaksi>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, value = string.Format("%{0}%",value)}, commandType: CommandType.Text);
                }

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasitransaksiByPageIndexAndFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(pelayananpasienpelunasan, string)> GetAsync(pelayananpasienpelunasan obj)
        {
            throw new NotImplementedException();
        }

        public int Save(pelayananpasienpelunasan obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@pelayananpasienpelunasanid", obj.pelayananpasienpelunasanid);
                p.Add("@strukpelayananid", obj.strukpelayananid);
                p.Add("@totalbayar", obj.totalbayar);
                p.Add("@totalpiutang", obj.totalpiutang);
                p.Add("@totalbebas", obj.totalbebas);
                p.Add("@created_date", DateTime.Now);
                p.Add("@updated_date", null);
                p.Add("@pelayananpasienpelunasansts", true);


                _sql = @"[p_Savepelayananpasienpelunasan]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }

        public bool Update(pelayananpasienpelunasan obj)
        {
            throw new NotImplementedException();
        }

        public int Save(IList<pelayananpasienpelunasan> obj, short strukpelayananid)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {
                DynamicParameters p = null;
                foreach (pelayananpasienpelunasan pelayanan in obj)
                {
                    p = new DynamicParameters();
                    p.Add("@pelayananpasienpelunasanid", pelayanan.pelayananpasienpelunasanid);
                    p.Add("@strukpelayananid", strukpelayananid);
                    p.Add("@totalbayar", pelayanan.totalbayar);
                    p.Add("@totalpiutang", pelayanan.totalpiutang);
                    p.Add("@totalbebas", pelayanan.totalbebas);
                    p.Add("@created_date", DateTime.Now);
                    p.Add("@updated_date", null);
                    p.Add("@pelayananpasienpelunasansts", true);


                    _sql = @"[p_Savepelayananpasienpelunasan]";
                    result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                    p = null;

                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }
    }
}
