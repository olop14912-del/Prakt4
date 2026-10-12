using Prakt4;
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

namespace Prakt4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Triad GetTriadA()
        {
            if (int.TryParse(txtA1.Text, out int a1) &&
                int.TryParse(txtA2.Text, out int a2) &&
                int.TryParse(txtA3.Text, out int a3))
                return new Triad(a1, a2, a3);

            MessageBox.Show("Введите три целых числа в триаду A");
            return null;
        }
        private Triad GetTriadB()
        {
            if (int.TryParse(txtB1.Text, out int b1) &&
                int.TryParse(txtB2.Text, out int b2) &&
                int.TryParse(txtB3.Text, out int b3))
                return new Triad(b1, b2, b3);

            MessageBox.Show("Введите три целых числа в триаду B");
            return null;
        }
        private bool GetNumber(out int number)
        {
            if (int.TryParse(txtNumber.Text, out number))
                return true;

            MessageBox.Show("Введите целое число");
            return false;
        }
        private void btnAddNumber_Click(object sender, RoutedEventArgs e)
        {
            Triad a = GetTriadA();
            if (a == null || !GetNumber(out int n)) return;

            txtResult.Text = a.Add(n).ToString();
        }
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Triad a = GetTriadA();
            if (a == null || !GetNumber(out int n)) return;

            txtResult.Text = a.Multiply(n).ToString();
        }
        private void btnAddTriad_Click(object sender, RoutedEventArgs e)
        {
            Triad a = GetTriadA();
            Triad b = GetTriadB();
            if (a == null || b == null) return;

            txtResult.Text = a.Add(b).ToString();
        }
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            Triad a = GetTriadA();
            Triad b = GetTriadB();
            if (a == null || b == null) return;

            if (a.IsEqual(b))
                txtResult.Text = "Триады равны";
            else
                txtResult.Text = "Триады не равны";
        }
        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Разработчик: Клейменов Никита\n" + 
                "Практическая работа №4\n" +
                "О программе");
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}