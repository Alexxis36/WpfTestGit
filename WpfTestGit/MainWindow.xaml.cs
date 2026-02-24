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

namespace WpfTestGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            int numberOne = int.Parse(TbNumberOne.Text);
            int numberTwo = int.Parse(TbNumberOne.Text);
            int res = numberOne + numberTwo;
            TblResult.Text = $"Результат сложения = {res}";
        }
    }
}