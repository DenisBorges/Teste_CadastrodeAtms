using CadastrodeAtms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DAO.Interface
{
    public interface IMunicipioDAO : ILeituraDAO<MunicipioModel>
    {
        MunicipioModel GetByCity(string name);
    }
}
