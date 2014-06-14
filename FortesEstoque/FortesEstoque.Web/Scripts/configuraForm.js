var configuraForm = function configuraForm(idForm,callback) {
    var instancia = $(idForm);
    instancia.submit(function (event) {
        var url = instancia.attr("action");
        var dados = instancia.serialize();
        $.post(url, dados, function (result) {            
            alert(result.mensagem);
            if (result.sucesso) {
                callback();
            }
        });
        return false;
    });
}
