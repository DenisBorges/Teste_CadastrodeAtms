$(document).ready(function () {

    (function OnInit() {
        if ($('#AtmPc').val() === '')
            $('div.form-group:not(:first)').find('input, select').attr('disabled', 'disabled');
    })();

    $('#AtmPc').on('change', function () {
  
        var pc = $(this).val();

        $.post('VerificarCodigo', {pc} ,(data) => {
            if (!data.status) {
                $('div.form-group:not(:first-child)').find('input,select').removeAttr('disabled');
            } else {
                window.location.href = '../Atm/NovoCadastro/' + data.id;
            }
        });

    });


    $('#AtmPa').on('change', function () {



        var pa = parseInt($(this).val());

        $.post('../../Atm/VerificarPontoDeControle', { pa }, (data) => {

            if (data !== null) {


                $('#AtmEndereco').val(data.endereco);

                $('#AtmComplemento').val(data.complemento);

                $('#AtmBairro').val(data.bairro);

                $('select#AtmUf').find('option:selected').removeAttr('selected');
                $('select#AtmUf').find('option').filter((index, element) => $(element).val() == data.uf).prop('selected', true);

                $('select#AtmCidade').find('option:selected').removeAttr('selected');
                $('select#AtmCidade').find('option').filter((index, element) => $(element).val() == data.cidade).prop('selected', true);

            }
        });

    });

    $('#Salvar').on('click', function () {


        var data = RetornaDados();


        if (Validar(data)) {
            $.ajax({
                url: '../Atm/Cadastrar',
                data: { atm: data },
                type: 'POST',
                success: () => {
                    alert('Cadastrado com Sucesso');
                    window.location.href = "../Atm/Index";
                },
                error: () => alert('Houve erro durante a tentativa de cadastro de ATM. Tente novamente')
            });
        }


    });


    $('#Atualizar').on('click', function () {

        var data = RetornaDados();

        if (Validar(data)) {
            $.ajax({
                url: '../AtualizarCadastro',
                data: { atm: data },
                type: 'POST',
                success: () => {
                    alert('Atualizado com Sucesso');
                    window.location.href = "../Index";
                },
                error: () => alert('Houve erro durante a tentativa de atualização de ATM. Tente novamente')
            });
        }


    });

    function RetornaDados() {

        return {
            id: $('#id').val(),
            AtmPc: $('#AtmPc').val(),
            AtmNome: $('#AtmNome').val(),
            AtmPa: parseInt($('#AtmPa').val()),
            AtmEndereco: $('#AtmEndereco').val(),
            AtmComplemento: $('#AtmComplemento').val(),
            AtmBairro: $('#AtmBairro').val(),
            AtmCidade: parseInt($('#AtmCidade').val()),
            AtmUf: parseInt($('#AtmUf option:selected').val()),
            AtmCep: $('#AtmCep').val(),
            AtmPontoRef: $('#AtmPontoRef').val(),
            AtmLatitude: $('#AtmLatitude').val(),
            AtmLongitude: $('#AtmLongitude').val()
        };

    }

    function Validar(obj) {
    
        if (obj.AtmPc === '' || obj.AtmPc === undefined || obj.AtmPc === null) {
            alert('O preenchimento do campo PC é obrigatório.');
            return false;
        }

        return true;
    }


});