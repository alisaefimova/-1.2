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
using Библиотека;

namespace Папытка1._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calc = new Calculator();

        double firstNumber = 0;
        string operation = "";
        bool isNewInput = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewInput)
            {
                Display.Text = "";
                isNewInput = false;
            }

            Display.Text += btn.Content.ToString();
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            firstNumber = double.Parse(Display.Text);
            operation = btn.Content.ToString();
            isNewInput = true;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double secondNumber = double.Parse(Display.Text);
                double result = 0;

                switch (operation)
                {
                    case "+": result = calc.Add(firstNumber, secondNumber); break;
                    case "-": result = calc.Subtract(firstNumber, secondNumber); break;
                    case "*": result = calc.Multiply(firstNumber, secondNumber); break;
                    case "/": result = calc.Divide(firstNumber, secondNumber); break;
                    case "^": result = calc.Power(firstNumber, secondNumber); break;
                }

                Display.Text = result.ToString();
                isNewInput = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Display.Text = "Ошибка";
                isNewInput = true;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            firstNumber = 0;
            operation = "";
            isNewInput = true;
        }
    }
}