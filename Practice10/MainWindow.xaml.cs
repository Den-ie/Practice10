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

namespace Practice10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        List<int> mas = new List<int>();
        Random random = new Random();

        private void Create(object sender, RoutedEventArgs e)
        {
            mas.Clear();

            if (int.TryParse(MasLength.Text, out int x))
            {
                for (int i = 0; i < x; i++)
                {
                    mas.Add(random.Next(1, 10));
                    masList.ItemsSource = null;
                    masList.ItemsSource = mas;
                }
            }
            else MessageBox.Show("Введите корректное значение");
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            int Max = 0;
            int Min = 10;
            int A = Convert.ToInt32(NumberA.Text);

            for(int i = 0; i < mas.Count; i++) 
            {
                if (mas[i] % 2 == 0)
                    if (mas[i] > Max) Max = mas[i];
            }
            
            for(int i = 0; i < mas.Count; i++) 
            {
                if (mas[i] % A == 0)
                    if (mas[i] < Max) Min = mas[i];
            }
            MessageBox.Show("Максимальное значение - " + Max + "\rМаксимальное значение - " + Min);
        }

        private void AboutProgramm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В одномерном массиве целых чисел найти максимальный среди элементов, \r\nявляющихся четными, и минимальный среди элементов, кратных А.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
