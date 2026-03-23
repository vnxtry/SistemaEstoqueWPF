using System.Collections.Generic;
using SistemaEstoqueWPF.Legado;
using SistemaEstoqueWPF.Models;

namespace SistemaEstoqueWPF.Adapters
{
    
    public class ErpAdapter : IFornecedor
    {
        private readonly SistemaErpAntigo _sistemaLegado;

        public ErpAdapter(SistemaErpAntigo sistemaLegado)
        {
            _sistemaLegado = sistemaLegado;
        }

        public List<ProdutoModerno> ObterProdutos()
        {
            
            List<ProdutoAntigo> itensAntigos = _sistemaLegado.BuscarItensNoBancoVelho();
            
            List<ProdutoModerno> produtosConvertidos = new List<ProdutoModerno>();

            foreach (var item in itensAntigos)
            {
                produtosConvertidos.Add(new ProdutoModerno
                {
                    Nome = item.Descricao_Item,
                    Preco = (decimal)item.Valor_Unitario_XML 
                });
            }

            return produtosConvertidos;
        }
    }
}