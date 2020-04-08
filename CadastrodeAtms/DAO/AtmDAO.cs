using CadastrodeAtms.DbConn;
using CadastrodeAtms.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CadastrodeAtms.DAO.Interface;

namespace CadastrodeAtms.DAO
{
    public class AtmDAO : IAtmDAO
    {
        private readonly Conexao Db;
        protected DbSet<AtmModel> DbSet;

        private readonly ILogger<IAtmDAO> _log;
        public AtmDAO(Conexao context, ILogger<IAtmDAO> log)
        {
            _log = log;
            Db = context;
            DbSet = Db.Set<AtmModel>();
        }

        public bool Delete(int id)
        {
            try
            {
                var registro = DbSet.FirstOrDefault(x => x.id == id);
                if(registro != null)
                {
                    DbSet.Remove(registro);
                    Db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
                return false;
            }
        }

        public AtmModel GetById(int id)
        {

            AtmModel obj = null;
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

        public AtmModel GetByPc(string pc)
        {
            AtmModel obj = null;
            try
            {
                obj = DbSet.FirstOrDefault(x => x.AtmPc == pc);

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
            }

            return obj;
        }

        public bool Insert(AtmModel obj)
        {
            try
            {
                DbSet.Add(obj);
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
                return false;
            }

            return true;
        }

        public List<AtmModel> Select()
        {

            List<AtmModel> lst = null;
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

        public bool Update(AtmModel obj)
        {
            try
            {
                Db.Entry(DbSet.FirstOrDefault(x => x.id == obj.id)).CurrentValues.SetValues(obj);
                Db.SaveChanges();

            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message, ex);
                return false;
            }

            return true;
        }
    }
}
