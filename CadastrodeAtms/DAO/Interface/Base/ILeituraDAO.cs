using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DAO.Interface
{
    public interface ILeituraDAO<T>
    {

        List<T> Select();

        T GetById(int id);
    }
}
