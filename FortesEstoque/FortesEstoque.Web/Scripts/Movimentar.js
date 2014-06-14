var Movimentar = (function () {

    var _build = function _build() {
        _alteraProduto();
    }

    var _alteraProduto = function _alteraProduto() {
        elementos.dplProdutos.change(function () {
            var produto = elementos.dplProdutos.val();
            var url = "Produto/Consultar?produto=" + produto;
            elementos.divMovimentacoes.load(url);
        });
    }

    var elementos = {};

    return {
        init: function () {
            elementos.dplProdutos = $("#dplProdutos");
            elementos.divMovimentacoes = $("#divMovimentacoes");
            var callback = function () { window.location.reload() };
            configuraForm("#formMovimentar", callback);
            _build();
        }
    };

})();