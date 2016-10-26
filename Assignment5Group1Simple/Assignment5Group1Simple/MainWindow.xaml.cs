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

namespace Assignment5Group1Simple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string DIRNAME = "Result";
        string FILENAME = "distanceCalculator.txt";
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Calculate()
        {
            int speed = int.Parse(txtSpeed.Text);
            int time = int.Parse(txtTime.Text);
            int distance;
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullpath = System.IO.Path.Combine(path, DIRNAME);
            Directory.CreateDirectory(fullpath);
            string filepath = System.IO.Path.Combine(fullpath, FILENAME);
            StreamWriter sw = File.CreateText(filepath);
            for(int i= 1; i<=time; i++)
            {
                distance = speed * i;
                string result = i + " " + distance;
                lstDistance.Items.Add(result);
                sw.WriteLine(result);
            }
            sw.Close();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }
    }
}
