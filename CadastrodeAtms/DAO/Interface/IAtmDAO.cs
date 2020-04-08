using CadastrodeAtms.DAO.Interface;
using CadastrodeAtms.DbConn;
using CadastrodeAtms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DAO.Interface
{
    public interface IAtmDAO:ILeituraDAO<AtmModel>,IGravacaoDAO<AtmModel>
    {
        AtmModel GetByPc(string pc);

    }
}
