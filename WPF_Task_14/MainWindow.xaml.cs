using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_Task_14
{
    /// <summary>
    /// Логика взаимодействия для WindowFonts.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Молоко",
                ProductCost = 65,
                ProductImage = "Data/1.png",
                ProductType = ProductTypes.Meal
            });
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductCost = 40,
                ProductImage = "Data/1.png",
                ProductType = ProductTypes.Meal
            });
            products.Add(new Product()
            {
                ProductName = "Холодильник",
                ProductCost = 50000,
                ProductImage = "Data/2.png",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Телевизор",
                ProductCost = 80000,
                ProductImage = "Data/2.png",
                ProductType = ProductTypes.Appliances
            });

            lstBox.ItemsSource = products;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            string prdimg;
            if (cmbBoxProductType.SelectedIndex == 0)
                prdimg = "Data/1.png";
            else prdimg = "Data/2.png";
            
            try
            {
                double cost = Convert.ToDouble(txtBoxProductCost.Text);
                products.Add(new Product()
                {
                    ProductName = txtBoxProductName.Text,
                    ProductCost = Convert.ToDouble(txtBoxProductCost.Text),
                    ProductImage = prdimg,
                    ProductType = (ProductTypes)cmbBoxProductType.SelectedIndex
                });

                txtBoxProductName.Text = null;
                txtBoxProductCost.Text = null;
                cmbBoxProductType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
