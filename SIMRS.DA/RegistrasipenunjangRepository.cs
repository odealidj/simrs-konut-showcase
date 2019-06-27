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
    public class RegistrasipenunjangRepository : IRegistrasipenunjangRepository
    {

        private string sErrthrowClassName = "RegistrasipenunjangRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RegistrasipenunjangRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RegistrasipenunjangRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public Task<(IEnumerable<v_distinctcaripasienpenunjang_not_in_registrasipenunjang>, string)> GetAllVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAsync(int pageIndex, int pageSize, short stsmasukkeluarid)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_distinctcaripasienpenunjang_not_in_registrasipenunjang>, string)> GetAllVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short stsmasukkeluarid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "select * from v_distinctcaripasienpenunjang_not_in_registrasipenunjang \n"
                    + "WHERE stsmasukkeluarid = @stsmasukkeluarid \n"
                    + "ORDER BY registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "select * from v_distinctcaripasienpenunjang_not_in_registrasipenunjang \n"
                    + "WHERE stsmasukkeluarid = @stsmasukkeluarid \n"
                   + "AND nocm+noregistrasi+nama LIKE @value \n"
                   + "ORDER BY registrasiid DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_distinctcaripasienpenunjang_not_in_registrasipenunjang> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_distinctcaripasienpenunjang_not_in_registrasipenunjang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, stsmasukkeluarid = stsmasukkeluarid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_distinctcaripasienpenunjang_not_in_registrasipenunjang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, stsmasukkeluarid = stsmasukkeluarid, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVdistinctcaripasienpenunjangNotInRegistrasipenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang>, string)> GetAllVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikpenunjangid)
        {
            #region query

            ////_sql = "SELECT * FROM  \n"
            ////    +"( \n"
            ////   +"SELECT * FROM v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang \n"
            ////    + "WHERE registrasiid = @registrasiid \n"
            ////   + "EXCEPT \n"
            ////   +"SELECT * FROM v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang \n"
            ////    + "WHERE registrasiid = @registrasiid and pelayananmedikpenunjangid = @pelayananmedikpenunjangid \n"
            ////    + ") AS q \n"
            ////   + "ORDER BY q.registrasiruangrawatid DESC";


            _sql = "SELECT * FROM v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang \n"
               + "WHERE registrasiid = @registrasiid \n"
              + "EXCEPT \n"
              + "SELECT * FROM v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang \n"
               + "WHERE registrasiid = @registrasiid and pelayananmedikpenunjangid = @pelayananmedikpenunjangid \n"
               + ") AS q \n"
              + "ORDER BY q.registrasiruangrawatid DESC";


            #endregion

            IEnumerable<v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang> list;

            try
            {

                    list = await _context.db.QueryAsync<v_ruangrawatcaripasienpenunjang_not_in_registrasipenunjang>(_sql, new { registrasiid = registrasiid, pelayananmedikpenunjangid = pelayananmedikpenunjangid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVruangrawatcaripasienpenunjangNotInRegistrasipenunjangByRegistrasiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public int Save(registrasipenunjang obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasipenunjangid", obj.registrasipenunjangid);
                p.Add("@tglregistrasi", obj.tglregistrasi);
                p.Add("@registrasiruangrawatid", obj.registrasiruangrawatid);
                p.Add("@ruangrawatid", (obj.ruangrawatid == -1) ? null : obj.ruangrawatid);
                p.Add("@kelasid", (obj.kelasid == -1) ? null : obj.kelasid);
                p.Add("@created_date", obj.created_date);
                p.Add("@updated_date", obj.updated_date);
                p.Add("@loginappid", (obj.loginappid == -1) ? null : obj.loginappid);
                p.Add("@registrasipenunjangsts", obj.registrasipenunjangsts);

                _sql = @"[p_Saveregistrasipenunjang]";
                result = _context.db.ExecuteScalar<int>(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

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

        public bool Update(registrasipenunjang obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(registrasipenunjang obj)
        {
            var result = false;

            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasipenunjangid", obj.registrasipenunjangid);
                
                _sql = @"[p_Deleteregistrasipenunjang]";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                result = true;

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = false;
            }

            return result;
        }

        public registrasipenunjang Get(registrasipenunjang obj)
        {
            throw new NotImplementedException();
        }

        public Task<(registrasipenunjang, string)> GetAsync(registrasipenunjang obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<registrasipenunjang> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<registrasipenunjang>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<registrasipenunjang>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_distinctpasienpenunjang>, string)> GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short stsmasukkeluarid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT[registrasiid] ,[tglmasuk],[jammasuk],[noregistrasi],[nocm] \n"
                      + ",[nama],[jknm],[tanggallahir],[thn],[bulan],[hari] \n"
                      + ",[penjaminpasienid],[penjaminpasiennm],[prosedurmasukid],[prosedurmasuknm] \n"
                      + ",[stsregistrasiid],[stsregistrasinm],[stsmasukkeluarid],[stsmasukkeluarnm] \n"
                      + "FROM[dbo].[v_distinctpasienpenunjang] \n"
                      + "WHERE pelayananmedikid = @pelayananmedikid \n"
                      + "AND stsmasukkeluarid = @stsmasukkeluarid \n"
                      + "ORDER BY registrasiid  DESC \n"
                      + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                      + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "SELECT[registrasiid] ,[tglmasuk],[jammasuk],[noregistrasi],[nocm] \n"
                     + ",[nama],[jknm],[tanggallahir],[thn],[bulan],[hari] \n"
                     + ",[penjaminpasienid],[penjaminpasiennm],[prosedurmasukid],[prosedurmasuknm] \n"
                     + ",[stsregistrasiid],[stsregistrasinm],[stsmasukkeluarid],[stsmasukkeluarnm] \n"
                     + "FROM[dbo].[v_distinctpasienpenunjang] \n"
                     + "WHERE pelayananmedikid = @pelayananmedikid \n"
                     + "AND stsmasukkeluarid = @stsmasukkeluarid \n"
                     + "AND nocm+noregistrasi+nama LIKE @value \n"
                     + "ORDER BY registrasiid  DESC \n"
                     + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                     + "FETCH NEXT @pageSize ROWS ONLY";

            }

            #endregion

            IEnumerable<v_distinctpasienpenunjang> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_distinctpasienpenunjang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, stsmasukkeluarid = stsmasukkeluarid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_distinctpasienpenunjang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, stsmasukkeluarid = stsmasukkeluarid, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat_penunjang>, string)> GetAllVregistrasiruangrawatpenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikid)
        {
            #region query


            _sql = "SELECT * FROM v_registrasiruangrawat_penunjang \n"
                + "WHERE registrasiid = @registrasiid and pelayananmedikpenunjangid = @pelayananmedikpenunjangid \n"
               + "ORDER BY registrasiruangrawatid DESC \n";


            #endregion

            IEnumerable<v_registrasiruangrawat_penunjang> list;

            try
            {

                list = await _context.db.QueryAsync<v_registrasiruangrawat_penunjang>(_sql, new { registrasiid = registrasiid, pelayananmedikpenunjangid = pelayananmedikid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiruangrawatpenunjangByRegistrasiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang>, string)> GetAllVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(short registrasiid, short pelayananmedikpenunjangid)
        {
            #region query


            _sql = "SELECT* FROM v_registrasiruangrawat_notin_registrasipenunjang AS d WHERE d.registrasiid = @registrasiid \n"
                + "AND d.registrasiruangrawatid  NOT IN(SELECT r.registrasiruangrawatid \n"
                + "FROM registrasipenunjang AS r INNER JOIN registrasiruangrawat AS r2 \n"
                + "ON r2.registrasiruangrawatid = r.registrasiruangrawatid INNER JOIN ruangrawat AS r3 ON r3.ruangrawatid = r.ruangrawatid \n"
                + "INNER JOIN pelayananmedik AS p ON p.pelayananmedikid = r3.pelayananmedikid WHERE p.pelayananmedikid = @pelayananmedikpenunjangid)";

            //_sql = "SELECT* FROM v_registrasiruangrawat_notin_registrasipenunjang AS d WHERE d.registrasiid = @registrasiid \n"
            //    + "ORDER BY d.registrasiruangrawatid ASC";


            #endregion

            IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang> list;

            try
            {

               list = await _context.db.QueryAsync<v_registrasiruangrawat_notin_registrasipenunjang>(_sql, new { registrasiid = registrasiid, pelayananmedikpenunjangid = pelayananmedikpenunjangid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang>, string)> GetDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync(int pageIndex, int pageSize, short pelayananmedikpenunjangid, short stsmasukkeluarid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))

            ////_sql = "SELECT * FROM v_registrasiruangrawat_notin_registrasipenunjang AS d \n"
            ////    + "Where d.ruangrawatid NOT IN(SELECT d2.ruangrawatid \n"
            ////    + "FROM v_registrasiruangrawat_in_registrasipenunjang AS d2 WHERE d2.pelayananmedikpenunjangid = @pelayananmedikpenunjangid) \n"
            ////    + "AND d.stsmasukkeluarid = @stsmasukkeluarid \n"
            ////    + "ORDER BY d.registrasiid  DESC \n"
            ////         + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
            ////         + "FETCH NEXT @pageSize ROWS ONLY";

            _sql = "SELECT distinct d.registrasiid,d.tglmasuk,d.noregistrasi,d.nocm,d.nama,d.jknm,d.tanggallahir,d.thn,d.bulan,d.hari,d.penjaminpasienid,d.penjaminpasiennm,d.stsmasukkeluarid,d.stsmasukkeluarnm \n"
                +"FROM v_registrasiruangrawat_notin_registrasipenunjang AS d \n"
                + "Where d.registrasiruangrawatid NOT IN(SELECT d2.registrasiruangrawatid \n"
                + "FROM v_registrasiruangrawat_in_registrasipenunjang AS d2 WHERE d2.pelayananmedikpenunjangid = @pelayananmedikpenunjangid) \n"
                + "AND d.stsmasukkeluarid = @stsmasukkeluarid \n"
                + "ORDER BY d.registrasiid  DESC \n"
                     + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                     + "FETCH NEXT @pageSize ROWS ONLY";

            ////_sql = "SELECT * FROM v_registrasiruangrawat_notin_registrasipenunjang AS d \n"
            ////    + "Where d.registrasiruangrawatid NOT IN(SELECT d2.registrasiruangrawatid \n"
            ////    + "FROM v_registrasiruangrawat_in_registrasipenunjang AS d2 WHERE d2.pelayananmedikpenunjangid = @pelayananmedikpenunjangid) \n"
            ////    + "AND d.stsmasukkeluarid = @stsmasukkeluarid \n"
            ////    + "ORDER BY d.registrasiid  DESC \n"
            ////         + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
            ////         + "FETCH NEXT @pageSize ROWS ONLY";

            else
            {
                //_sql = "SELECT * FROM v_registrasiruangrawat_notin_registrasipenunjang AS d \n"
                //+ "Where d.ruangrawatid NOT IN(SELECT d2.ruangrawatid \n"
                //+ "FROM v_registrasiruangrawat_in_registrasipenunjang AS d2 WHERE d2.pelayananmedikpenunjangid = @pelayananmedikpenunjangid) \n"
                //+ "AND d.stsmasukkeluarid = @stsmasukkeluarid \n"
                //+ "AND d.nocm+d.noregistrasi+d.nama LIKE @value \n"
                //+ "ORDER BY d.registrasiid  DESC \n"
                //     + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                //     + "FETCH NEXT @pageSize ROWS ONLY";

                _sql = "SELECT distinct d.registrasiid,d.tglmasuk,d.noregistrasi,d.nocm,d.nama,d.jknm,d.tanggallahir,d.thn,d.bulan,d.hari,d.penjaminpasienid,d.penjaminpasiennm,d.stsmasukkeluarid,d.stsmasukkeluarnm \n"
                    + "FROM v_registrasiruangrawat_notin_registrasipenunjang AS d \n"
                    + "Where d.registrasiruangrawatid NOT IN(SELECT d2.registrasiruangrawatid \n"
                    + "FROM v_registrasiruangrawat_in_registrasipenunjang AS d2 WHERE d2.pelayananmedikpenunjangid = @pelayananmedikpenunjangid) \n"
                    + "AND d.stsmasukkeluarid = @stsmasukkeluarid \n"
                    + "AND d.nocm+d.noregistrasi+d.nama LIKE @value \n"
                    + "ORDER BY d.registrasiid  DESC \n"
                         + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                         + "FETCH NEXT @pageSize ROWS ONLY";

            }

            #endregion

            IEnumerable<v_registrasiruangrawat_notin_registrasipenunjang> list;

            try
            {
                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat_notin_registrasipenunjang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikpenunjangid = pelayananmedikpenunjangid, stsmasukkeluarid = stsmasukkeluarid, }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat_notin_registrasipenunjang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikpenunjangid = pelayananmedikpenunjangid, stsmasukkeluarid = stsmasukkeluarid, value = string.Format("%{0}%",value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetDistinctVregistrasiruangrawatnotinregistrasipenunjangByRegistrasiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_distinctpasienpenunjang>, string)> GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync(int pageIndex, int pageSize, short pelayananmedikid, short stsmasukkeluarid, DateTime tglmasuk)
        {
            #region query

            _sql = "SELECT[registrasiid] ,[tglmasuk],[jammasuk],[noregistrasi],[nocm] \n"
                      + ",[nama],[jknm],[tanggallahir],[thn],[bulan],[hari] \n"
                      + ",[penjaminpasienid],[penjaminpasiennm],[prosedurmasukid],[prosedurmasuknm] \n"
                      + ",[stsregistrasiid],[stsregistrasinm],[stsmasukkeluarid],[stsmasukkeluarnm] \n"
                      + "FROM[dbo].[v_distinctpasienpenunjang] \n"
                      + "WHERE pelayananmedikid = @pelayananmedikid \n"
                      + "AND stsmasukkeluarid = @stsmasukkeluarid \n"
                      + "AND tglmasuk = @tglmasuk \n"
                      + "ORDER BY registrasiid  DESC \n"
                      + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                      + "FETCH NEXT @pageSize ROWS ONLY";
            

           

            #endregion

            IEnumerable<v_distinctpasienpenunjang> list;

            try
            {

               
                    list = await _context.db.QueryAsync<v_distinctpasienpenunjang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, stsmasukkeluarid = stsmasukkeluarid, tglmasuk = tglmasuk.Date.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);
                
               
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVdistinctpasienpenunjangByPageIndexAndStsmasukkeluarIdAndFilterByNocmNoregNamaAsyncAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
