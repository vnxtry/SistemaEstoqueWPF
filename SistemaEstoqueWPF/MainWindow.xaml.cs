using System.Windows;
using SistemaEstoqueWPF.ViewModels;

namespace SistemaEstoqueWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = new MainViewModel();
        }
    }
}