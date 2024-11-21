using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DI_UD3_10
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* EJERCICIO 2
        public MainWindow()
        {
            InitializeComponent();

            Button button = new Button();
            button.FontWeight = FontWeights.Bold;
            WrapPanel wrapPanel = new WrapPanel();

            TextBlock text1 = new TextBlock { Text = "Texto 1", Foreground = Brushes.Green };
            TextBlock text2 = new TextBlock { Text = "Texto 2", Foreground = Brushes.Blue };
            TextBlock text3 = new TextBlock { Text = "Texto 3" };

            wrapPanel.Children.Add(text1);
            wrapPanel.Children.Add(text2);
            wrapPanel.Children.Add(text3);

            button.Content = wrapPanel;

            this.Content = button;
        }*/

        /*EJERCICIO 3
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evento lanzado desde el botón. El evento es de tipo bubbling.");
        }*/

        /*EJERCICIO 5
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
        }*/

        /*EJERCICIO 7
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Forzando una excepción
                int[] array = new int[5];
                array[10] = 100; // Esto genera una excepción
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha capturado una excepción: {ex.Message}");
            }
        }*/

        /*EJERCICIO 9
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este es un mensaje personalizado.");
        }*/
        /*
        private void txtBox2DAM_SelectionChanged(object sender, RoutedEventArgs e)
        {
            txtStatus.Text = "Selection starrts at character #"+txtBox2DAM.SelectionStart+Environment.NewLine;
            txtStatus.Text += "Selection is " + txtBox2DAM.SelectionLength + "character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: " + txtBox2DAM.SelectedText + " ";
        }*/
    }
}
 