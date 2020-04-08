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
    public class UfDAO : IUfDAO
    {

        private readonly Conexao Db;
        protected DbSet<UfModel> DbSet;

        private readonly ILogger<IUfDAO> _log;
        public UfDAO(Conexao context, ILogger<IUfDAO> log)
        {
            _log = log;
            Db = context;
            DbSet = Db.Set<UfModel>();
        }

        public UfModel GetById(int id)
        {
            UfModel obj = null;
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

        public List<UfModel> Select()
        {
            List<UfModel> lst = null;
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

        public UfModel GetByUF(string name)
        {
            UfModel obj = null;
            try
            {

                obj = DbSet.FirstOrDefault(x => x.UfNome == name);

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
            }

            return obj;
        }
    }
}
