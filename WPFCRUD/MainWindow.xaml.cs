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
using System.Xml.Serialization;
using WPFCRUD.Classes;

namespace WPFCRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!File.Exists("films.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Film>));
                using (FileStream fs = new FileStream("films.xml", FileMode.OpenOrCreate))
                {
                    List<Film> films = new List<Film> { };
                    formatter.Serialize(fs,films);
                }
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Film>));
            using(FileStream fs=new FileStream("films.xml", FileMode.OpenOrCreate))
            {
                List<Film> films = (List<Film>)formatter.Deserialize(fs);
                dgFilms.ItemsSource = films;
            }
        }
    }
}
