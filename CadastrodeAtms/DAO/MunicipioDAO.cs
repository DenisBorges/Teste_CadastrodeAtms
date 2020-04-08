using CadastrodeAtms.DAO.Interface;
using CadastrodeAtms.DbConn;
using CadastrodeAtms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DAO
{
    public class MunicipioDAO : IMunicipioDAO
    {

        private readonly Conexao Db;
        protected DbSet<MunicipioModel> DbSet;

        private readonly ILogger<IMunicipioDAO> _log;
        public MunicipioDAO(Conexao context, ILogger<IMunicipioDAO> log)
        {
            _log = log;
            Db = context;
            DbSet = Db.Set<MunicipioModel>();
        }


        public MunicipioModel GetById(int id)
        {
            MunicipioModel obj = null;
            try
            {

                obj = DbSet.FirstOrDefault(x => x.id == id);

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
            }

            return obj;
        }

        public List<MunicipioModel> Select()
        {
            List<MunicipioModel> lst = null;
            try
            {

                lst = DbSet.ToList();

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
            }

            return lst;
        }

        public MunicipioModel GetByCity(string name)
        {
            MunicipioModel obj = null;
            try
            {

                obj = DbSet.FirstOrDefault(x => x.MunNome == name);

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
            }

            return obj;
        }


    }
}
