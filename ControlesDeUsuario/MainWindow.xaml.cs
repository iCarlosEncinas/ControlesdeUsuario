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

namespace ControlesDeUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
            lblresultado.Text = 0.ToString();
            switch (cbFigura.SelectedIndex)
            {
                case 0: //Círculo
                    grdParametrosFigura.Children.Add(new ParametrosCírculo());
                    break;
                case 1: //Triángulo
                    grdParametrosFigura.Children.Add(new ParametrosTriángulo());
                    break;
                case 2: //Cuadrado
                    grdParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;
                case 3: //Rectángulo
                    grdParametrosFigura.Children.Add(new ParametrosRectángulo());
                    break;
                case 4: //Trapecio
                    grdParametrosFigura.Children.Add(new ParametroTrapecio());
                    break;
                case 5: //Pentagono
                    grdParametrosFigura.Children.Add(new ParametrosPentagono());
                    break;
                default:
                    break;
                
            }
        }

        private void BtnCalcularÁrea_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbFigura.SelectedIndex)
            {
                case 0: //Círculo
                    double radio = double.Parse(((ParametrosCírculo)(grdParametrosFigura.Children[0])).txtRadio.Text);
                    area = Math.PI * (radio * radio);
                    break;
                case 1: //Triángulo
                    double Base = double.Parse(((ParametrosTriángulo)(grdParametrosFigura.Children[0])).txtAlturaTriángulo.Text);
                    double Altura = double.Parse(((ParametrosTriángulo)(grdParametrosFigura.Children[0])).txtAlturaTriángulo.Text);
                    area = (Base * Altura) / 2;
                    break;
                case 2: //Cuadrado
                    double lado = double.Parse(((ParametrosCuadrado)(grdParametrosFigura.Children[0])).txtLado.Text);
                    area = (lado * lado);
                    break;
                case 3: //Rectángulo
                    double BaseRec = double.Parse(((ParametrosRectángulo)(grdParametrosFigura.Children[0])).txtBase.Text);
                    double AlturaRec = double.Parse(((ParametrosRectángulo)(grdParametrosFigura.Children[0])).txtAltura.Text);
                    area = (BaseRec * AlturaRec);
                    break;
                case 4: //Trapecio
                    double BaseMenor = double.Parse(((ParametroTrapecio)(grdParametrosFigura.Children[0])).txtBaseMenor.Text);
                    double BaseMayor = double.Parse(((ParametroTrapecio)(grdParametrosFigura.Children[0])).txtBaseMayor.Text);
                    double AlturaTra = double.Parse(((ParametroTrapecio)(grdParametrosFigura.Children[0])).txtAltura.Text);

                    area = ((BaseMenor + BaseMayor) * AlturaTra) / 2;
                    break;
                case 5: //Pentagono
                    grdParametrosFigura.Children.Add(new ParametrosPentagono());
                    double perimetro = double.Parse(((ParametrosPentagono)(grdParametrosFigura.Children[0])).txtPerimetro.Text);
                    double apotema = double.Parse(((ParametrosPentagono)(grdParametrosFigura.Children[0])).txtApotema.Text);

                    area = ((perimetro * apotema) / 2);
                    break;
                default:
                    break;
            }
            lblresultado.Text = area.ToString();
        }
    }
}
