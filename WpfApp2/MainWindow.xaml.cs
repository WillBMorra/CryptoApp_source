using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainPage main = new MainPage(this);
            this.Content = main;
           
            

        }

       
    }

    public record struct assets(double price, string name, double volume_24h, string description, string status, string website);

    class FileMenu
    {
        public void Write(object content)
        {
            string path = "Test.txt";
            string pathj = "Test.json";


            if (File.Exists(pathj))
            {
                File.Delete("Test.json");
                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);
                sw.WriteLine(content);
                sw.Close();
                File.Move(path, pathj);
            }

            else
            {

                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);
                sw.WriteLine(content);
                sw.Close();
                File.Move(path, pathj);
            }




        }

    }

}
