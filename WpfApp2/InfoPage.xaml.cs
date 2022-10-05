using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public InfoPage(Window MainWindow, List<assets> assets, int index = 0, ChoiseEnum.ChoiseLibrary choise = ChoiseEnum.ChoiseLibrary.Standart)
        {
            string website = assets[index].website;
            string description = assets[index].description;
            if (assets[index].website == "") 
            {
                website = "None";
            }

            if (assets[index].description == "")
            {
                description = "None";
            }
            InitializeComponent();
            CurrencyInfo_Text.Text = 
                ($"Name:{assets[index].name} \n" +
                $"\nPrice: {assets[index].price}\n" +
                $"\nVolume(24h): {assets[index].volume_24h}\n" +
                $"\nStatus: {assets[index].status}\n" +
                $"\nWebsite: {website}\n" +
                $"\nDescription: {description}");
            BackButton.Click += (sender, args) => 
            {
                MainPage main = new MainPage(MainWindow,choise);

                MainWindow.Content = main;
            };
        }
       
        
    }
}
