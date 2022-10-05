using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        
        public MainPage(Window MainWindow, ChoiseEnum.ChoiseLibrary choise = ChoiseEnum.ChoiseLibrary.Standart)
        {
            InitializeComponent();

           
            List<Buttons> scrollmenu = new List<Buttons>();
            List<assets> assets = new List<assets>();
            Asset_Installer asseter = new Asset_Installer();
            assets = asseter.GetAssets();

            NumberSort_btn.Click += (sender, args) =>
            {
                MainPage mpage = new MainPage(MainWindow, ChoiseEnum.ChoiseLibrary.SortedByNum);
                MainWindow.Content = mpage;
            };

            NameSort_btn.Click += (sender, args) =>
            {
                MainPage mpage = new MainPage(MainWindow, ChoiseEnum.ChoiseLibrary.SortedByName);
                MainWindow.Content = mpage;
            };

            switch (choise)
            {
                case ChoiseEnum.ChoiseLibrary.Standart: break;
                case ChoiseEnum.ChoiseLibrary.SortedByNum: asseter.SortByInt(assets, assets.Count); break;
                case ChoiseEnum.ChoiseLibrary.SortedByName: asseter.SortByName(assets, assets.Count); break;
                default: break;
            }


            for (int i = 0; i < assets.Count; i++)
            {
                    scrollmenu.Add(new Buttons(MainWindow, assets, i, 0, 30, 50 + 30 * (i), 0, $"{assets[i].name} : {assets[i].price}", choise));

            }

            

            for (int i = 0; i < assets.Count; i++)
            {
                ListGrid.Children.Add(scrollmenu[i].button);
            }
        }
       
    }

   
}
