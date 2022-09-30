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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero;
        public MainWindow()
        {
            numero = GeneraAleatorio();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = numero, numEntrada = int.Parse(entrada.Text);
            if(numEntrada == num) { salida.Text = "Has acertado!!"; }
            else if(numEntrada > num) { salida.Text = "Te has pasado"; }
            else { salida.Text = "Te has quedado corto"; }
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            numero = GeneraAleatorio();
            entrada.Text = "";
        }
        private int GeneraAleatorio() 
        {
            Random rnd = new Random();
            int resultado = rnd.Next(99);
            return resultado;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Method intentionally left empty.
        }
    }
}
