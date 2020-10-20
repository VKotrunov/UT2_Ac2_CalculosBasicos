using System;
using System.Windows;
using System.Windows.Controls;

namespace UT2_Ac2_CalculosBasicos
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            bool op1 = double.TryParse(OP1.Text, out double num1);
            bool op2 = double.TryParse(OP2.Text, out double num2);
            if (op1 && op2)
            {
                switch (operador.Text)
                {
                    case "+":
                        resultado.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        resultado.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        resultado.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        if(num2!=0)
                            resultado.Text = (num1 / num2).ToString();
                        else
                            resultado.Text = "∞";
                        break;
                    default:
                
                        break;
                }
            }else
                MessageBox.Show("Se ha producido un error. Revise los operandos.", "Calculadora básica");
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            OP1.Text = "";
            OP2.Text = "";
            operador.Text = "";
            resultado.Text = "";
            calcularButton.IsEnabled = false;
        }

        private void operador_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (operador.Text)
            {
                case "+":
                    calcularButton.IsEnabled = true;
                    break;
                case "-":
                    calcularButton.IsEnabled = true;
                    break;
                case "*":
                    calcularButton.IsEnabled = true;
                    break;
                case "/":
                    calcularButton.IsEnabled = true;
                    break;
                default:
                    calcularButton.IsEnabled = false;
                    break;
            }
        }
    }
}
