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

namespace lab1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        double a, b, c;
        try
        {
            a = Convert.ToDouble(AInput.Text);
            b = Convert.ToDouble(BInput.Text);
            c = Convert.ToDouble(CInput.Text);
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid input");
            return;
        }
        var expression = new LExpression(a, b, c);

        var result = expression.Calculate();
        ResultOutput.Content = result.Length == 0 ? "0 answers" : string.Join(", ", result);
    }
}
