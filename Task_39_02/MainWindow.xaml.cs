using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products = new();
        public MainWindow()
        {
            InitializeComponent();
            productsListBox.ItemsSource = Products;
        }
        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            string name; int count;
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Поле названия не должно быть пустым");
                return;
            }            
            if (string.IsNullOrEmpty(countTextBox.Text))
            {
               countTextBox.Text = "1"; 
            }
            if (!int.TryParse(countTextBox.Text, out count))
            {
                MessageBox.Show("В поле количества должно быть число");
                return;
            }
            Product product = new(nameTextBox.Text, int.Parse(countTextBox.Text));
            Products.Add(product);
            Clear();
        }
        private void saveProductTotxt_Click(object sender, RoutedEventArgs e)
        {
        var saveFileDialoge = new SaveFileDialog() 
        {
            Title = "Сохранить в файл",
            DefaultExt = ".txt",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        };
        if (saveFileDialoge.ShowDialog() == true)
            {
                try
                {
                    var lines = new List<string>();
                    foreach (var product in Products)
                    {
                        lines.Add($"{product.Name} - {product.Count}");
                    }

                    File.WriteAllLines(saveFileDialoge.FileName, lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }
        private void importProductFromtxt_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Title = "Открыть из файла",
                DefaultExt = ".txt"
            };
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    var lines = File.ReadAllLines(openFileDialog.FileName);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(" - ");
                        if (parts.Length == 2 && !string.IsNullOrEmpty(parts[0]) && int.TryParse(parts[1], out var count))
                        {
                            var product = new Product(parts[0], int.Parse(parts[1]));
                            Products.Add(product);
                        }
                        else
                        {
                            MessageBox.Show("Некорректный формат строки", "Ошибка формата", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
        private void deliteProductListBoxConMenu_Click(object sender, RoutedEventArgs e) 
        {
            var item = productsListBox.SelectedItem;
            if (item != null && item is Product product)
            {
                Products.Remove(product);
            }
        }
        public void Clear()
        {
            nameTextBox.Clear();
            countTextBox.Clear();
        }
    }
}