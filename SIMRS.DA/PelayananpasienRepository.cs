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
    public class PelayananpasienRepository : IPelayananpasienRepository
    {
        private string sErrthrowClassName = "PelayananpasienRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PelayananpasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PelayananpasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(pelayananpasien obj)
        {
            var result = false;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@pelayananpasienid", obj.pelayananpasienid);
                
                _sql = @"[p_Deletepelayananpasien]";
                _context.db.ExecuteScalar<int>(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                result = true;
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = false;
            }

            return result;
        }

        public pelayananpasien Get(pelayananpasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pelayananpasien> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<pelayananpasien>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<pelayananpasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_pelayananpasien>, string)> GetAllVpelayananpasienByRegistrasiIdAsync(short registrasiid)
        {
            #region query

                _sql = "SELECT * FROM v_pelayananpasien WHERE registrasiid = @registrasiid ORDER BY pelayananpasienid DESC";
            
            #endregion

            IEnumerable<v_pelayananpasien> list = null;

            try
            {

                    list = await _context.db.QueryAsync<v_pelayananpasien>(_sql, new { registrasiid = registrasiid }, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVpelayananpasienByRegistrasiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(pelayananpasien, string)> GetAsync(pelayananpasien obj)
        {
            throw new NotImplementedException();
        }

        public int Save(pelayananpasien obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {
                //                @pelayananpasienid int = NULL,
                //@pelayananpasientgl datetime = NULL,
                //    @pelayananpasienjam datetime = NULL,
                //    @registrasiruangrawatid smallint = NULL,
                //    @pelayananmedikid smallint = NULL,
                //    @dokterid smallint = NULL,
                //    @perawatid smallint = NULL,
                //    @jenistarifid varchar(2) = NULL,
                //    @tarifid int = NULL,
                //    @biaya money = NULL,
                //    @jml smallint = NULL,
                //    @totalbiaya money = NULL,
                //    @loginappid smallint = NULL,
                //    @created_date datetime = NULL,
                //    @updated_date datetime = NULL,
                //    @pelayananpasiensts bit = NULL

                DynamicParameters p = new DynamicParameters();
                p.Add("@pelayananpasienid", obj.pelayananpasienid);
                p.Add("@pelayananpasientgl", obj.pelayananpasientgl);
                p.Add("@pelayananpasienjam", obj.pelayananpasienjam);
                p.Add("@registrasiruangrawatid",obj.registrasiruangrawatid);
                p.Add("@registrasipenunjangid", (obj.registrasipenunjangid==-1) ? null: obj.registrasipenunjangid);
                p.Add("@dokterid", (obj.dokterid == -1) ? null : obj.dokterid);
                p.Add("@perawatid", (obj.perawatid == -1) ? null : obj.perawatid);
                p.Add("@jenistarifid", (obj.jenistarifid == string.Empty) ? null : obj.jenistarifid);
                p.Add("@tarifid", obj.tarifid);
                p.Add("@biaya", obj.biaya);
                p.Add("@jml", obj.jml);
                p.Add("@totalbiaya", obj.totalbiaya);
                p.Add("@loginappid", (obj.loginappid == -1) ? null : obj.loginappid);
                p.Add("@created_date", DateTime.Now);
                p.Add("@updated_date", null);
                p.Add("@pelayananpasiensts", true);


                

                _sql = @"[p_Savepelayananpasien]";
                result = _context.db.ExecuteScalar<int>(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

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

        public bool Update(pelayananpasien obj)
        {
            throw new NotImplementedException();
        }

        public int SaveKarcis(v_pelayananpasienkarcis vpelayananpasienkarcis)
        {
            var result = -99;

            sErrthrowMethodName = "SaveKarcis";

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@pelayananpasienid", vpelayananpasienkarcis.pelayananpasienid);
                p.Add("@pelayananpasientgl", vpelayananpasienkarcis.pelayananpasientgl);
                p.Add("@pelayananpasienjam", vpelayananpasienkarcis.pelayananpasienjam);
                p.Add("@registrasiruangrawatid", vpelayananpasienkarcis.registrasiruangrawatid);
                p.Add("@pelayananmedikid", vpelayananpasienkarcis.pelayananmedikid);
                p.Add("@jenistarifid", vpelayananpasienkarcis.jenistarifid);
                p.Add("@ruangrawatid", vpelayananpasienkarcis.ruangrawatid);
                p.Add("@kelasid", vpelayananpasienkarcis.kelasid);
                p.Add("@stspasienbaruid", vpelayananpasienkarcis.stspasienbaruid);
                p.Add("@loginappid", (vpelayananpasienkarcis.loginappid == -1) ? null : vpelayananpasienkarcis.loginappid);

                _sql = @"[p_SavepelayananpasienKarcis]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //result = -1;
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "SaveKarcis";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }

        public async Task<(IEnumerable<v_tindakanpoli>, string)> GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid,short ruangrawatid)
        {
            #region query

            _sql = "SELECT * FROM v_tindakanpoli \n"
                +"WHERE registrasiid = @registrasiid AND ruangrawatid = @ruangrawatid \n"
                +"ORDER BY pelayananpasientgl DESC";

            #endregion

            IEnumerable<v_tindakanpoli> list = null;

            try
            {

                list = await _context.db.QueryAsync<v_tindakanpoli>(_sql, new { registrasiid = registrasiid, ruangrawatid= ruangrawatid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_tindakanpoli>, string)> GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, DateTime tgltindakan)
        {
            #region query

            _sql = "SELECT * FROM v_tindakanpoli \n"
                + "WHERE registrasiid = @registrasiid AND ruangrawatid = @ruangrawatid AND pelayananpasientgl = @pelayananpasientgl\n"
                + "ORDER BY pelayananpasienid DESC";

            #endregion

            IEnumerable<v_tindakanpoli> list = null;

            try
            {

                

                list = await _context.db.QueryAsync<v_tindakanpoli>(_sql, new { registrasiid = registrasiid, ruangrawatid = ruangrawatid, pelayananpasientgl = tgltindakan.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVtindakanpoliByRegistrasiIdAndRuangrawatIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

             return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_tindakanpenunjang>, string)> GetAllVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, short ruangrawatpenunjangid)
        {
            #region query

            _sql = "SELECT * FROM v_tindakanpenunjang \n"
                + "WHERE registrasiid = @registrasiid AND ruangrawatid = @ruangrawatid AND ruangrawatpenunjangid = @ruangrawatpenunjangid\n"
                + "ORDER BY pelayananpasientgl DESC";

            #endregion

            IEnumerable<v_tindakanpenunjang> list = null;

            try
            {

                list = await _context.db.QueryAsync<v_tindakanpenunjang>(_sql, new { registrasiid = registrasiid, ruangrawatid = ruangrawatid, ruangrawatpenunjangid = ruangrawatpenunjangid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_tindakanpenunjang>, string)> GetAllVtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync(short registrasiid, short ruangrawatid, short ruangrawatpenunjangid, DateTime tgltindakan)
        {
            #region query

            _sql = "SELECT * FROM v_tindakanpenunjang \n"
                + "WHERE registrasiid = @registrasiid AND ruangrawatid = @ruangrawatid AND ruangrawatpenunjangid = @ruangrawatpenunjangid AND pelayananpasientgl = @pelayananpasientgl\n"
                + "ORDER BY pelayananpasienid DESC";

            #endregion

            IEnumerable<v_tindakanpenunjang> list = null;

            try
            {



                list = await _context.db.QueryAsync<v_tindakanpenunjang>(_sql, new { registrasiid = registrasiid, ruangrawatid = ruangrawatid, ruangrawatpenunjangid = ruangrawatpenunjangid, pelayananpasientgl = tgltindakan.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllvtindakanpenunjangByRegistrasiIdAndRuangrawatIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        //Modul Kasir
        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> Get50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize, short stsmasukkeluarid)
        {
            #region query

            _sql = "SELECT TOP 50 * FROM v_pelayananpasien_distinct_from_not_alamat AS pdfna \n"
                + "WHERE pdfna.stsmasukkeluarid = @stsmasukkeluarid \n";


            if (stsmasukkeluarid == 1)//sts masuk
            {
                _sql = _sql + "ORDER BY pdfna.tglmasuk DESC \n";
            }
            else
            {
                _sql = _sql + "ORDER BY pdfna.tglkeluar DESC \n";
            }

            //_sql = _sql + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
            //    + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_pelayananpasien_distinct_from_not_alamat> list;

            try
            {


                list = await _context.db.QueryAsync<v_pelayananpasien_distinct_from_not_alamat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, stsmasukkeluarid = stsmasukkeluarid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Get50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize, short stsmasukkeluarid, string filter)
        {
            #region query

            _sql = "SELECT * FROM v_pelayananpasien_distinct_from_not_alamat AS pdfna \n"
                + "WHERE pdfna.stsmasukkeluarid = @stsmasukkeluarid \n"
                + "AND pdfna.noregistrasi+pdfna.nocm+pdfna.nama LIKE @filter \n";


            if (stsmasukkeluarid == 1)//sts masuk
            {
                _sql = _sql + "ORDER BY pdfna.tglmasuk DESC \n";
            }
            else
            {
                _sql = _sql + "ORDER BY pdfna.tglkeluar DESC \n";
            }

            _sql = _sql + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_pelayananpasien_distinct_from_not_alamat> list;

            try
            {


                list = await _context.db.QueryAsync<v_pelayananpasien_distinct_from_not_alamat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, stsmasukkeluarid = stsmasukkeluarid, filter = string.Format("%{0}%",filter)  }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync(int pageIndex, int pageSize, DateTime tglmasuk)
        {
            #region query

            _sql = "SELECT * FROM v_pelayananpasien_distinct_from_not_alamat AS pdfna \n"
                + "WHERE pdfna.stsmasukkeluarid = 1 \n"
                + "AND pdfna.tglmasuk = @tglmasuk \n"
                + "ORDER BY pdfna.registrasiid DESC \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_pelayananpasien_distinct_from_not_alamat> list;

            try
            {


                list = await _context.db.QueryAsync<v_pelayananpasien_distinct_from_not_alamat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, tglmasuk = tglmasuk.Date.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglKeluarAsync(int pageIndex, int pageSize, DateTime tglkeluar)
        {
            #region query

            _sql = "SELECT * FROM v_pelayananpasien_distinct_from_not_alamat AS pdfna \n"
                + "WHERE pdfna.stsmasukkeluarid = 1 \n"
                + "AND pdfna.tglkeluar = @tglkeluar \n"
                + "ORDER BY pdfna.registrasiid DESC \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_pelayananpasien_distinct_from_not_alamat> list;

            try
            {


                list = await _context.db.QueryAsync<v_pelayananpasien_distinct_from_not_alamat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, tglkeluar = tglkeluar.Date.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglKeluarAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_pelayananpasien_ruangperawatan_from_not_alamat>, string)> GetAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync(int registrasiid)
        {
            #region query

            _sql = "SELECT distinct * FROM v_pelayananpasien_ruangperawatan_from_not_alamat AS prfna \n"
                + "WHERE prfna.registrasiid = @registrasiid \n"
                + "ORDER BY prfna.registrasiruangrawatid ASC";

            #endregion

            IEnumerable<v_pelayananpasien_ruangperawatan_from_not_alamat> list;

            try
            {

                list = await _context.db.QueryAsync<v_pelayananpasien_ruangperawatan_from_not_alamat>(_sql, new { registrasiid = registrasiid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_pelayananpasien_rincian_not_alamat>, string)> GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync(int registrasiid)
        {
            #region query

            _sql = "SELECT * FROM v_pelayananpasien_rincian_not_alamat \n"
                + "WHERE registrasiid = @registrasiid \n"
                + "ORDER BY pelayananmedikid ASC, ruangrawatid2 ASC, pelayananpasientgl DESC";

            #endregion

            IEnumerable<v_pelayananpasien_rincian_not_alamat> list;

            try
            {

                list = await _context.db.QueryAsync<v_pelayananpasien_rincian_not_alamat>(_sql, new { registrasiid = registrasiid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_pelayananpasien_rincian_not_alamat>, string) GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiId(int registrasiid)
        {
            #region query

            _sql = "SELECT * FROM v_pelayananpasien_rincian_not_alamat \n"
                + "WHERE registrasiid = @registrasiid \n"
                + "ORDER BY pelayananmedikid ASC, ruangrawatid2 ASC, pelayananpasientgl DESC";

            #endregion

            IEnumerable<v_pelayananpasien_rincian_not_alamat> list;

            try
            {

                list = _context.db.Query<v_pelayananpasien_rincian_not_alamat>(_sql, new { registrasiid = registrasiid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
