using Dapper;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA
{
    public class RegistrasiRepository : IRegistrasiRepository
    {

        private string sErrthrowClassName = "RegistrasiRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RegistrasiRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RegistrasiRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(registrasi obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<registrasi> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<registrasi>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoCM(int pageIndex, int pageSize, string nocm)
        {
            #region query
  

             _sql = "SELECT \n"
               + "	registrasiid, \n"
               + "	nocm, \n"
               + "	noregistrasi, \n"
               + "	prosedurmasukid, \n"
               + "	tglmasuk, \n"
               + "  jammasuk, \n"
               + "	tglkeluar, \n"
               + "	instalasipelayananid, \n"
               + "	kelasid, \n"
               + "	kelasnm, \n"
               + "	ruangrawatid, \n"
               + "	ruangrawatnm, \n"
               + "	kamarid, \n"
               + "	penjaminpasienid, \n"
               + "	petugasid, \n"
               + "	klpkpasiendid, \n"
               + "	penjaminpasiennm, \n"
               + "	klpkpasiendnm, \n"
               + "	registrasists, \n"
               + "	ruangrawatsts, \n"
               + "	instalasipelayanannm \n"
               + "FROM \n"
               + "	[simrs].[dbo].[v_registrasi]"
               + "Where nocm = @nocm \n"
               + "ORDER BY noregistrasi DESC \n"
               + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
               + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_registrasi> list;

            try
            {
                list = await _context.db.QueryAsync<v_registrasi>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, nocm = string.Format("{0}%", nocm) }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasiByPageIndexAndNoCM";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return list;
        }

        public Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoregistrasi(int pageIndex, int pageSize, string nocm, string noregistrasi)
        {
            throw new NotImplementedException();
        }

        public int Save(registrasi obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(registrasi obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoCMAndNoregistrasi(int pageIndex, int pageSize, string nocm, string noregistrasi)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<v_registrasi>> GetAllv_registrasiByPageIndexAndNoCM(int pageIndex, int pageSize, EnuminstalasiPelayanan instalasipelayanan, string nocm)
        {
            //if(instalasipelayanan==InstalasiPelayanan.RawatJalan)
            throw new NotImplementedException();
        }

        public registrasi Get(registrasi obj)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<registrasi>,string)> GetAllAsync()
        {

            throw new NotImplementedException();
        }

        public Task<(registrasi, string)> GetAsync(registrasi obj)
        {
            throw new NotImplementedException();
        }

        (short, string, string) IRegistrasiRepository.Save(registrasi obj)
        {
            var result = 0;
            short? registrasiid = 0;
            string noregistrasi = string.Empty;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasiid", obj.registrasiid, DbType.Int16, ParameterDirection.InputOutput);
                p.Add("@nocm", obj.nocm);
                p.Add("@noregistrasi", obj.noregistrasi, DbType.String, ParameterDirection.InputOutput);
                p.Add("@prosedurmasukid", obj.prosedurmasukid);
                p.Add("@stspasienbaruid", obj.stspasienbaruid);
                p.Add("@tglmasuk", obj.tglmasuk);
                p.Add("@jammasuk", obj.jammasuk);
                //p.Add("@tglkeluar", obj.tglkeluar);
                p.Add("@penjaminpasienid", (obj.penjaminpasienid == -1) ? null : obj.penjaminpasienid);
                //p.Add("@petugasid", (obj.petugasid == -1) ? null : obj.petugasid);
                //p.Add("carapulangid", (obj.carapulangid == -1) ? null : obj.carapulangid);
                //p.Add("kondisipulangid", (obj.kondisipulangid == -1) ? null : obj.kondisipulangid);
                p.Add("stsmasukkeluarid", (obj.stsmasukkeluarid == -1) ? null : obj.stsmasukkeluarid);
                p.Add("loginappid", (obj.loginappid == -1) ? null : obj.loginappid);
                p.Add("registrasists",obj.registrasists);

                _sql = @"p_Saveregistrasi"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                registrasiid = p.Get<short>("registrasiid");
                noregistrasi = p.Get<string>("noregistrasi");
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                registrasiid = null;noregistrasi = string.Empty;
            }

            return ((short)registrasiid, noregistrasi, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi>,string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAsync(int pageIndex, int pageSize, short pelayananmedikid)
        {
            #region query

                _sql = "SELECT* FROM v_registrasi AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid \n"
                   + "ORDER BY r.registrasiid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi> list;

            try
            {
                
                
                    list = await _context.db.QueryAsync<v_registrasi>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid }, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi>,string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasi AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid  \n"
                   + "ORDER BY r.registrasiid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "SELECT* FROM v_registrasi AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                   + "ORDER BY r.registrasiid  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_registrasi> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasi>(_sql, new { pageIndex = pageIndex, pageSize = pageSize , pelayananmedikid = pelayananmedikid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasi>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable< v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk)
        {
            #region query

           
                _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                        + "WHERE tglmasuk = @tglmasuk \n"
                        + "ORDER BY registrasiid DESC  \n"
                        + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                        + "FETCH NEXT @pageSize ROWS ONLY";
          
            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, tglmasuk = tglmasuk.Date.ToString("yyyy-MM-dd") },  commandType: CommandType.Text);
               
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, string value)
        {
            #region query


            _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                    + "WHERE tglmasuk = @tglmasuk AND noregistrasi+nocm+nama  LIKE @value \n"
                    + "ORDER BY registrasiid DESC  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, tglmasuk = tglmasuk.Date.ToString("yyyy-MM-dd"), value = string.Format("%{0}%", value) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, int? stsmasukkeluar)
        {
            #region query


            _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                    + "WHERE tglmasuk = @tglmasuk AND stsmasukkeluarid = @stsmasukkeluarid \n"
                    + "ORDER BY registrasiid DESC  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, tglmasuk = tglmasuk.Date.ToString("yyyy-MM-dd"), stsmasukkeluarid = stsmasukkeluar }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, DateTime tglmasuk, string value, int? stsmasukkeluar)
        {
            #region query


            _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                    + "WHERE tglmasuk = @tglmasuk AND noregistrasi+nocm+nama  LIKE @value AND stsmasukkeluarid = @stsmasukkeluarid \n"
                    + "ORDER BY registrasiid DESC  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, tglmasuk = tglmasuk.Date.ToString("yyyy-MM-dd"), value = string.Format("%{0}%", value), stsmasukkeluarid = stsmasukkeluar }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, string value)
        {
            #region query


            _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                    + "WHERE noregistrasi+nocm+nama  LIKE @value \n"
                    + "ORDER BY registrasiid DESC  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, string value, int? stsmasukkeluar)
        {
            #region query


            _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                    + "WHERE noregistrasi+nocm+nama  LIKE @value AND stsmasukkeluarid = @stsmasukkeluarid \n"
                    + "ORDER BY registrasiid DESC  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, value = string.Format("%{0}%", value), stsmasukkeluarid = stsmasukkeluar }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize)
        {
            #region query


            _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                    + "ORDER BY registrasiid DESC  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat>, string)> GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync(int pageIndex, int pageSize, int? stsmasukkeluar)
        {
            #region query


            _sql = "select * from v_registrasi_rekammedis_from_vregistrasiruangrawat \n"
                    + "WHERE stsmasukkeluarid = @stsmasukkeluarid \n"
                    + "ORDER BY registrasiid DESC  \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasi_rekammedis_from_v_registrasiruangrawat> list;

            try
            {
                //var date = tglmasuk.Date.ToString("yyyy-MM-dd");

                list = await _context.db.QueryAsync<v_registrasi_rekammedis_from_v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, stsmasukkeluarid = stsmasukkeluar }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_registrasi_rekammedis_from_v_registrasiruangrawatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public int UpdateStsmasukkeluaraAndTglKeluar(short registrasiid, short stsmasukkeluarid, DateTime tglkeluar, DateTime jamkeluar)
        {
            var result = -99;

            sErrthrowMethodName = "UpdateStsmasukkeluaraAndTglKeluar";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasiid", registrasiid);
                p.Add("@stsmasukkeluarid", stsmasukkeluarid);
                p.Add("@tglkeluar", tglkeluar);
                p.Add("@jamkeluar", jamkeluar);


                _sql = @"[p_UpdateStsmasukkeluaraAndTglKeluar]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "UpdateStsmasukkeluaraAndTglKeluar";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }

        public int UpdateCaraPulang(short registrasiid, byte carapulangid)
        {
            var result = -99;

            sErrthrowMethodName = "UpdateCaraPulang";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasiid", registrasiid);
                p.Add("@carapulangid", carapulangid);

                _sql = @"[p_UpdateCaraPulang]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "UpdateCaraPulang";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }

        public stspasienbaru GetStspasienbaruByRegistrasiId(short registrasiid)
        {
            #region query

           
            _sql = "SELECT s.* FROM registrasi AS r \n"
                + "INNER JOIN stspasienbaru AS s ON s.id = r.stspasienbaruid \n"
                + "WHERE r.registrasiid = @registrasiid";


            #endregion

            stspasienbaru list;

            try
            {
               
                list = _context.db.QueryFirstOrDefault<stspasienbaru>(_sql, new { registrasiid = registrasiid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetStspasienbaruByRegistrasiId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }
    }
}
