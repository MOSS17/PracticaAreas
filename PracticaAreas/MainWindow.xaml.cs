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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();/*
            ValorBaseRectangulo.Text = "0";
            ValorAlturaRectangulo.Text = "0";
            ValorBaseTriangulo.Text = "0";
            ValorAlturaTriangulo.Text = "0";
            ValorRadio.Text = "0";
            ValorBaseMayor.Text = "0";
            ValorBaseMenor.Text = "0";
            ValorAlturaTrapecio.Text = "0";*/
        }
        /*
        private void CalcularRectangulo_Click(object sender, RoutedEventArgs e)
        {
            float ValorBase = float.Parse(ValorBaseRectangulo.Text);
            float ValorAltura = float.Parse(ValorAlturaRectangulo.Text);
            float Area = ValorBase * ValorAltura;
            AreaRectangulo.Text = Area.ToString();
        }

        private void CalcularTriangulo_Click(object sender, RoutedEventArgs e)
        {
            float ValorBase = float.Parse(ValorBaseTriangulo.Text);

            float ValorAltura = float.Parse(ValorAlturaTriangulo.Text);

            float Area = (ValorBase * ValorAltura) / 2;

            AreaTriangulo.Text = Area.ToString();
        }

        private void CalcularCirculo_Click(object sender, RoutedEventArgs e)
        {
            float Radio = float.Parse(ValorRadio.Text);

            float Area = ((float)Math.PI)*Radio*Radio ;

            AreaCirculo.Text = Area.ToString();
        }

        private void CalcularTrapecio_Click(object sender, RoutedEventArgs e)
        {
            float BaseMenor = float.Parse(ValorBaseMenor.Text);

            float BaseMayor = float.Parse(ValorBaseMayor.Text);

            float Altura = float.Parse(ValorAlturaTrapecio.Text);

            float Area = Altura * ((BaseMayor + BaseMenor) / 2);

            AreaTrapecio.Text = Area.ToString();
        }*/

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Rectángulo
                    panelConfiguracion.Children.Add(
                        new ControlAreaRectangulo());
                    break;
                case 1: //Triángulo
                    panelConfiguracion.Children.Add(
                        new ControlAreaTriangulo());
                    break;
                case 2: //Círculo
                    panelConfiguracion.Children.Add(
                        new ControlAreaCirculo());
                    break;
                case 3: //Trapecio
                    panelConfiguracion.Children.Add(
                        new ControlAreaTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Rectángulo
                    var controlAreaRectangulo = (ControlAreaRectangulo)panelConfiguracion.Children[0];

                    float ValorBase = float.Parse(controlAreaRectangulo.ValorBaseRectangulo.Text);
                    
                    float ValorAltura = float.Parse(controlAreaRectangulo.ValorAlturaRectangulo.Text);

                    area = ValorBase * ValorAltura;

                    break;
                case 1: //Triángulo
                    var controlAreaTriangulo = (ControlAreaTriangulo)panelConfiguracion.Children[0];

                    ValorBase = float.Parse(controlAreaTriangulo.ValorBaseTriangulo.Text);

                    ValorAltura = float.Parse(controlAreaTriangulo.ValorAlturaTriangulo.Text);

                    area = (ValorBase * ValorAltura) / 2;

                    break;
                case 2: //Círculo
                    var controlAreaCirculo = (ControlAreaCirculo)panelConfiguracion.Children[0];

                    float radio = float.Parse(controlAreaCirculo.ValorRadio.Text);

                    area = 3.14159f * radio * radio;

                    break;
                case 3: //Trapecio
                    var controlAreaTrapecio = (ControlAreaTrapecio)panelConfiguracion.Children[0];
                    
                    float BaseMenor = float.Parse(controlAreaTrapecio.ValorBaseMenor.Text);

                    float BaseMayor = float.Parse(controlAreaTrapecio.ValorBaseMayor.Text);

                    float Altura = float.Parse(controlAreaTrapecio.ValorAlturaTrapecio.Text);

                    area = Altura * ((BaseMayor + BaseMenor) / 2);


                    break;
            }
            lblResultadoArea.Text =
                area.ToString();
        }
    }
}
