using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using SistemaEstoqueWPF.Adapters;
using SistemaEstoqueWPF.Legado;
using SistemaEstoqueWPF.Models;

namespace SistemaEstoqueWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // ObservableCollection avisa a tela automaticamente quando itens são adicionados
        public ObservableCollection<ProdutoModerno> Produtos { get; set; }
        
       
        public ICommand ImportarCommand { get; }

        public MainViewModel()
        {
            Produtos = new ObservableCollection<ProdutoModerno>();
            ImportarCommand = new RelayCommand(ImportarDadosDoErp);
        }

        private void ImportarDadosDoErp(object obj)
        {
           
            SistemaErpAntigo erpVelho = new SistemaErpAntigo();
            IFornecedor fornecedor = new ErpAdapter(erpVelho);
            
            var produtosConvertidos = fornecedor.ObterProdutos();
            
            Produtos.Clear();
            foreach (var produto in produtosConvertidos)
            {
                Produtos.Add(produto);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}