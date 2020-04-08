using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DAO.Interface
{
    public interface IGravacaoDAO<T>
    {
        bool Insert(T obj);
        bool Update(T obj);

        bool Delete(int id);
    }
}
