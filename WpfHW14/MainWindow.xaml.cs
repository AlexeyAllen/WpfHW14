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

namespace WpfHW14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            products = new List<Product>();

            products.Add(new Product()
            {
                ProductName = "Apple",
                Price = 20,
                ImageName = "Data/Apple.jpg",
                ProductType = ProductTypes.Food
            });

            products.Add(new Product()
            {
                ProductName = "Orange",
                Price = 30,
                ImageName = "Data/Orange.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "SmartPhone",
                Price = 100,
                ImageName = "Data/SmartPhone.jpg",
                ProductType = ProductTypes.Devices
            });
            products.Add(new Product()
            {
                ProductName = "Laptop",
                Price = 200,
                ImageName = "Data/Laptop.jpg",
                ProductType = ProductTypes.Devices
            });
            lstBox.ItemsSource = products;
        }
    }
}
