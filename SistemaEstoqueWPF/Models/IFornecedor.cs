using System.Collections.Generic;

namespace SistemaEstoqueWPF.Models
{
    public interface IFornecedor
    {
        List<ProdutoModerno> ObterProdutos();
    }
}