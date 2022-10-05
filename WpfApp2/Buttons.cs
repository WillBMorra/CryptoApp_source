using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    internal class Buttons
    {
        public Button button = new Button();
        int margintop, margindown;
        public Buttons(Window page1,List<assets> assets, int index = 0,  int x = 0, int y = 0, int margintop = 0, int margindown = 0, string str = "None", ChoiseEnum.ChoiseLibrary choise = ChoiseEnum.ChoiseLibrary.Standart)
        {
            button.VerticalAlignment = VerticalAlignment.Top;
            
            this.margintop = margintop;
            this.margindown = margindown;
            button.Height = y;
            if (x != 0) { button.Width = x; }
            button.Margin = new Thickness(0, margintop, 0, margindown);
            TextBlock text = new TextBlock();
            text.Text = str;
            button.Content = text;
            button.HorizontalContentAlignment = HorizontalAlignment.Left;
            button.Click += (sender, args) =>
            {
                InfoPage page2 = new InfoPage(page1, assets, index, choise);
                page1.Content = page2;
            };

        }
        
    }

    
}
