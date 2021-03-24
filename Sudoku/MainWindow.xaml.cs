using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;


namespace Sudoku
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

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex pattern = new Regex(@"[^0-9]+");
            e.Handled = pattern.IsMatch(e.Text);
        }
    }
}
