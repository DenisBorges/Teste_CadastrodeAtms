using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastrodeAtms.DAO;
using CadastrodeAtms.DAO.Interface;
using CadastrodeAtms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace CadastrodeAtms.Controllers
{
    public class AtmController : Controller
    {

        private readonly IAtmDAO _atmService;
        private readonly IMunicipioDAO _municipioService;
        private readonly IUfDAO _ufService;

        private readonly ILogger<AtmController> _log;
        public AtmController(IAtmDAO atmService, IMunicipioDAO municipioService, IUfDAO ufService, ILogger<AtmController> log)
        {
            _atmService = atmService;
            _municipioService = municipioService;
            _ufService = ufService;
            _log = log;
        }

        public IActionResult Index()
        {

            List<AtmModel> lst = new List<AtmModel>();

            try
            {
                lst = _atmService.Select();
            }
            catch (Exception ex)
            {

                _log.LogError(ex.Message, ex);
                return BadRequest("Erro ao efetuar a listagem de ATM's");
            }

            return View(lst);
        }

        public IActionResult NovoCadastro(int? id)
        {

            AtmModel atm = null;

            if (id.HasValue)
            {
                atm = _atmService.GetById(id.Value);

            }

            LoadDropDowns(atm);

            return View(atm);
        }




        [HttpPost]
        public IActionResult Cadastrar(AtmModel atm)
        {

            try
            {
                _atmService.Insert(atm);

            }
            catch (Exception ex)
            {
                _log.LogError("Erro ao salvar Atm", ex);
                return BadRequest("Erro ao salvar Atm. Tente novamente");
            }

            return Json("");

        }

        [HttpPost]
        public IActionResult AtualizarCadastro(AtmModel atm)
        {

            try
            {
                _atmService.Update(atm);

            }
            catch (Exception ex)
            {
                _log.LogError("Erro ao atualizar Atm", ex);
                return BadRequest("Erro ao atualizar Atm. Tente novamente");
            }

            return Json("");
        }

        [HttpPost]
        public IActionResult VerificarPontoDeControle(int pa)
        {

            object retorno = null;

            try
            {
                var atm = _atmService.Select().FirstOrDefault(x => x.AtmPa == pa);

                if (atm != null)
                    retorno = new
                    {
                        Endereco = atm.AtmEndereco,
                        Bairro = atm.AtmBairro,
                        UF = atm.AtmUf,
                        Complemento = atm.AtmComplemento,
                        Cidade = atm.AtmCidade
                    };
            }
            catch (Exception)
            {

                throw;
            }


            return Json(retorno);

        }


        [HttpPost]
        public IActionResult VerificarCodigo(string pc)
        {
            bool result = false;
            int idItem = 0;

            try
            {
                var resultado = _atmService.GetByPc(pc);

                if (resultado != null)
                {
                    result = true;
                    idItem = resultado.id;
                }


            }
            catch (Exception ex)
            {
                _log.LogError("Erro ao Verificar código", ex);
                return BadRequest("Erro ao verificar Código. Tente novamente");
            }


            return Json(new
            {
                status = result,
                id = idItem

            }); ;

        }

        [HttpPost]
        public IActionResult Apagar(int id)
        {
            bool result = false;

            try
            {
                result = _atmService.Delete(id);

            }
            catch (Exception ex)
            {
                _log.LogError("Erro ao Verificar código", ex);
                return BadRequest("Erro ao verificar Código. Tente novamente");
            }

            return Json(result);

        }


        private void LoadDropDowns(AtmModel atm)
        {

            var ufList = _ufService.Select();
            List<SelectListItem> dropDownUfList = new List<SelectListItem>();

            if (ufList.Any())
            {
                dropDownUfList = _ufService.Select().Select(x =>
                {

                    bool isSelected = false;
                    if (atm != null)
                        isSelected = atm.AtmUf == x.id;

                    return new SelectListItem()
                    {
                        Text = x.UfNome,
                        Value = x.id.ToString(),
                        Selected = isSelected
                    };


                }).ToList();

                //ADD DEFAULT
                dropDownUfList.Insert(0, new SelectListItem() { Text = "", Value = "" });

                ViewBag.Estados = dropDownUfList;
            }


            var cityList = _municipioService.Select();
            List<SelectListItem> dropDownCityList = new List<SelectListItem>();


            if (cityList.Any())
            {
                dropDownCityList = _municipioService.Select().Select(x =>
                {

                    bool isSelected = false;
                    if (atm != null)
                        isSelected = atm.AtmCidade == x.id;

                    return new SelectListItem()
                    {
                        Text = x.MunNome,
                        Value = x.id.ToString(),
                        Selected = isSelected
                    };


                }).ToList();

                //ADD DEFAULT
                dropDownCityList.Insert(0, new SelectListItem() { Text = "", Value = "" });

                ViewBag.Municipios = dropDownCityList;
            }

        }
    }
}