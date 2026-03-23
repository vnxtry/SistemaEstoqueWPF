using System.Collections.Generic;

namespace SistemaEstoqueWPF.Legado
{
    public class SistemaErpAntigo
    {
        public List<ProdutoAntigo> BuscarItensNoBancoVelho()
        {
            return new List<ProdutoAntigo>
            {
                new ProdutoAntigo { Descricao_Item = "Teclado Mecânico XPTO", Valor_Unitario_XML = 150.50 },
                new ProdutoAntigo { Descricao_Item = "Mouse Sem Fio", Valor_Unitario_XML = 85.00 },
                new ProdutoAntigo { Descricao_Item = "Monitor 24 Pol", Valor_Unitario_XML = 899.99 },
                new ProdutoAntigo { Descricao_Item = "Cadeira Ergonômica", Valor_Unitario_XML = 1200.00 }
            };
        }
    }
}