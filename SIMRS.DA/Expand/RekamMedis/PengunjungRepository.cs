using SIMRS.DA.IRepository;
using SIMRS.DA.IRepository.IExpand.RekamMedis;
using SIMRS.Model.customobject.rekammedis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA.Expand.RekamMedis
{
    public class PengunjungRepository : IPengunjungRepository
    {
        private string sErrthrowClassName = "KartuBPJSRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PengunjungRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }
        public async Task<(IEnumerable<copengunjung>, string)> getAllPengunjung(int tahun, int bulan)
        {
            sErrResult = null;

            _sql = "SELECT " 
                +"ROW_NUMBER() OVER(ORDER BY a.stspasienbaruid ASC) AS nomor, "
                +"a.tahun,a.bulan, a.JenisKegiatan, sum(a.jml) AS jml "
                +" FROM "
                +"( "
                    +"SELECT @tahun AS tahun, @bulan AS bulan, "
	                +"case when s2.id = 0 THEN 'Pengunjung Baru' ELSE 'Pengunjung Lama' END AS JenisKegiatan, "
                    +"0 AS  jml, s2.id AS stspasienbaruid FROM stspasienbaru AS s2 "

                +"UNION "

                    +"SELECT DISTINCT YEAR(r.tglmasuk) AS tahun, MONTH(r.tglmasuk) AS bulan, "
	                +"case when r.stspasienbaruid = 0 THEN 'Pengunjung Baru' ELSE 'Pengunjung Lama' END AS JenisKegiatan, "
	                +"SUM(case when r.stspasienbaruid IS NULL THEN 0 ELSE 1 END) jml, s2.id AS stspasienbaruid "
                    +"FROM stspasienbaru AS s2 "
                    +"INNER JOIN registrasi AS r ON s2.id = r.stspasienbaruid "
                    + "AND YEAR(r.tglmasuk) =  @tahun AND MONTH(r.tglmasuk) = @bulan "
                    +"left OUTER JOIN identitaspasien AS i ON r.nocm = i.nocm "
                    +"left OUTER JOIN registrasiruangrawat AS r2 ON r2.registrasiid = r.registrasiid "
                    //+"--left OUTER JOIN pelayananpasien AS p ON p.registrasiruangrawatid = r2.registrasiruangrawatid "
                    //+"--left OUTER JOIN pelayananpasienpelunasan AS p2 ON p2.pelayananpasienpelunasanid = p.pelayananpasienid "
                    //+"--left OUTER JOIN strukpelayanan AS s ON s.strukpelayananid = p2.strukpelayananid

                    +"GROUP BY YEAR(r.tglmasuk) ,MONTH(r.tglmasuk), "
                    +"case when r.stspasienbaruid = 0 THEN 'Pengunjung Baru' ELSE 'Pengunjung Lama' END, "
	                +"r.stspasienbaruid ,s2.id "

                +") AS a "

                +"group by a.tahun,a.bulan, a.JenisKegiatan, a.stspasienbaruid "
                + "ORDER BY a.stspasienbaruid ASC ";


            IEnumerable<copengunjung> list;

            try
            {

                list = await _context.db.QueryAsync<copengunjung>(_sql, new { tahun = tahun, bulan = bulan }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "getAllPengunjungAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
