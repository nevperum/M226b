using System;
using System.Collections.Generic;
using System.IO;
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

namespace Exeptions.Circle
{

   
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamReader stream = null;
            try
            {
               stream = new StreamReader(@"C:\Users\Nevin\Desktop\Privaes\Moti.txt");
                MessageBox.Show(stream.ReadToEnd());

                stream.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show($" \a Fehler. {ex.Message}");
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        private void btnException1_Click(object sender, RoutedEventArgs e)
        {
            StreamReader stream = new StreamReader(@"C:\Users\Nevin\Desktop\Privates\Moti.txt");
            MessageBox.Show(stream.ReadToEnd());

            stream.Close();
        }

        private void btnException5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader stream = new StreamReader(@"C:\Users\Nevin\Desktop\Privaes\Moti.txt");
                MessageBox.Show(stream.ReadToEnd());

                stream.Close();

            }
          

            catch(IOException ex)
            {
                MessageBox.Show($" \a Fehler. {ex.Message}");
            }

            catch (Exception ex)
            {

                MessageBox.Show($" \a Fehler. {ex.Message}");
            }
        }

        private void btnException2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnException4_Click(object sender, RoutedEventArgs e)
        {
            Circle c = new Circle();

        }
    }
}
