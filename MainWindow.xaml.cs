using DriveMyself.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examen
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.DataProvider = new MySqlDataProvider();
            ProductList = Globals.DataProvider.GetProducts();
        }
        public IEnumerable<Product> ProductList { get; set; }


        public string[] SortList { get; set; } = {
    "Без сортировки",
    "цена по убыванию",
    "цена по возрастанию" };
    }
}

     