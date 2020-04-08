using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadastrodeAtms.Models
{
    public class MunicipioModel:Entity
    {

        public MunicipioModel() {}

        public MunicipioModel(int _id,string Nome, int Uf)
        {
            this.id = _id;
            this.MunNome = Nome;
            this.MunUf = Uf;
        }

        public string MunNome { get; set; }
        public int MunUf { get; set; }
        public float? MunIss { get; set; }
        public float? MunIcms { get; set; }
        public float? MunIcmsInterno { get; set; }
        public virtual ICollection<AtmModel> atms { get; set; }
        public UfModel uf { get; set; }
    }
}
