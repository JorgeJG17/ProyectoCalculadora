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

namespace ProyectoCalculadora
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Operaciones(object sender, RoutedEventArgs e)
        {
            //Convertimos en el objeto sender en objeto de tipo Button.
            //sender es un parámetro de evento que generalmente se utiliza
            //para hacer referencia al objeto que desencadenó el evento.
            Button button = (Button)sender;

            //Convertimos la etiqyeta de antes en String
            string valor = (button.Tag).ToString();

            string operador;

            switch (valor)
            {
                case "restar":
                    operador = "res";
                    Operar(operador);
                    break;

                case "dividir":
                    operador = "div";
                    Operar(operador);
                    break;

                case "multiplicar":
                    operador = "multi";
                    Operar(operador);
                    break;

                case "sumar":
                    operador = "sum";
                    Operar(operador);
                    break;

                case "raiz":
                    operador = "raiz";
                    Operar(operador);
                    break;

                case "borrar":
                    operador = "bor";
                    Operar(operador);
                    break;

                case "igual":
                    operador = "ig";
                    Operar(operador);
                    break;
            }
        }

        private void Button_Numeros(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            int valor = int.Parse((button.Tag).ToString());

            string numero;

            switch (valor)
            {
                case 0:
                    numero = "0";
                    Visual(numero);
                    break;

                case 1:
                    numero = "1";
                    Visual(numero);
                    break;

                case 2:
                    numero = "2";
                    Visual(numero);
                    break;

                case 3:
                    numero = "3";
                    Visual(numero);
                    break;

                case 4:
                    numero = "4";
                    Visual(numero);
                    break;

                case 5:
                    numero = "5";
                    Visual(numero);
                    break;

                case 6:
                    numero = "6";
                    Visual(numero);
                    break;

                case 7:
                    numero = "7";
                    Visual(numero);
                    break;

                case 8:
                    numero = "8";
                    Visual(numero);
                    break;

                case 9:
                    numero = "9";
                    Visual(numero);
                    break;


            }

        }

        private void Visual(string numero)
        {
            if (Resultado.Text == "0")
            {
                Resultado.Text = numero;
            }
            else
            {
                Resultado.Text = Resultado.Text + numero;
            }
        }

        private void Operar(string operador)
        {

            switch (operador)
            {
                case "res":
                    simbolo = "-";
                    resultado = double.Parse(Resultado.Text);
                    Resultado.Text = "0";
                    break;

                case "div":
                    simbolo = "/";
                    resultado = double.Parse(Resultado.Text);
                    Resultado.Text = "0";
                    break;

                case "multi":
                    simbolo = "*";
                    resultado = double.Parse(Resultado.Text);
                    Resultado.Text = "0";
                    break;

                case "sum":
                    simbolo = "+";
                    resultado = double.Parse(Resultado.Text);
                    Resultado.Text = "0";
                    break;

                case "raiz":
                    simbolo = "√";
                    resultado = double.Parse(Resultado.Text);
                    Resultado.Text = "0";
                    break;

                case "bor":
                    resultado = 0;
                    Resultado.Text = "0";
                    break;

                case "ig":

                    switch (simbolo)
                    {
                        case "-":
                            resultado = resultado - double.Parse(Resultado.Text);
                            break;

                        case "+":
                            resultado = resultado + double.Parse(Resultado.Text);
                            break;

                        case "*":
                            resultado = resultado * double.Parse(Resultado.Text);
                            break;

                        case "/":
                            resultado = resultado / double.Parse(Resultado.Text);
                            break;

                        case "√":
                            resultado = Math.Sqrt(double.Parse(Resultado.Text));
                            break;

                    }

                    Resultado.Text = resultado.ToString();
                    break;
            }


        }

        //Variables que sirven para esta clase unicamente.
        private string simbolo = "valorDefecto";
        private double resultado = 0;
    }
}