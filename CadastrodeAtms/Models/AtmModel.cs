using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.Models
{
    public class AtmModel:Entity
    {
        [Required]
        [StringLength(5)]
        [Display(Name="Código do Equipamento TECBAN(PC)")]
        public string AtmPc { get; set; }

        [StringLength(50)]
        [Display(Name = "Nome")]
        public string AtmNome { get; set; }

 
        [Display(Name = "Ponto de Atendimento (PA)")]
        public int? AtmPa { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho é até 50 caracteres")]
        [Display(Name = "Endereço")]
        public string AtmEndereco { get; set; }

        [StringLength(20, ErrorMessage = "O tamanho é até 20 caracteres")]
        [Display(Name = "Complemento")]
        public string AtmComplemento { get; set; }

        [StringLength(20, ErrorMessage = "O tamanho é até 20 caracteres")]
        [Display(Name = "Bairro")]
        public string AtmBairro { get; set; }

        [Display(Name = "Cidade")]
        public int AtmCidade { get; set; }
        public MunicipioModel Cidade { get; set; }

        [Display(Name = "UF")]
        public int AtmUf { get; set; }
        public UfModel Uf { get; set; }

        [StringLength(20, ErrorMessage = "O tamanho é até 50 caracteres")]
        [Display(Name = "CEP")]
        public string AtmCep { get; set; }

        [StringLength(50,ErrorMessage ="O tamanho é até 50 caracteres")]
        [Display(Name = "Ponto de Referencia")]
        public string AtmPontoRef { get; set; }

        [RegularExpression(@"^\d+\.\d{0,6}$", ErrorMessage = "O Formato precisa atender o padrão com 8 números e 6 decimais Ex: 88888888.888888")]
        [Range(0,999999.99)]
        [Display(Name = "Latitude")]
        public string AtmLatitude { get; set; }

        [RegularExpression(@"^\d+\.\d{0,6}$", ErrorMessage="O Formato precisa atender o padrão com 8 números e 6 decimais Ex: 88888888.888888")]
        [Range(0, 999999.99)]
        [Display(Name = "Longitude")]
        public string AtmLongitude { get; set; }

    }
}
