using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadastrodeAtms.Models
{
    public class UfModel:Entity
    {

        public UfModel(){}

        public UfModel(int _id,string sigla, string nome)
        {
            this.id = _id;
            this.UfSigla = sigla;
            this.UfNome = nome;
            this.DataCadastro = DateTime.Now;
            this.DataAtualizacao = DateTime.Now;
        }
        [StringLength(2)]
        public string UfSigla { get; set; }
        public string UfNome { get; set; }

        public virtual ICollection<MunicipioModel> municipios { get; set; }
        public virtual ICollection<AtmModel> atms { get; set; }
    }
}
