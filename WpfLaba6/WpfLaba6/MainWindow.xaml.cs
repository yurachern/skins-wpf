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

namespace WpfLaba6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OvalSkin()
        {
            ResourceDictionary newDictionary = new ResourceDictionary();
            newDictionary.Source = new Uri("OvalSkin.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries[0] = newDictionary;         
        }
        private void RectangularSkin()
        {
            ResourceDictionary newDictionary = new ResourceDictionary();
            newDictionary.Source = new Uri("RectangularSkin.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries[0] = newDictionary;           
        }
        
        private void CbStyles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbStyles.SelectedIndex != -1)
            {
                switch (cbStyles.SelectedIndex)
                {
                    case 0:
                        OvalSkin();
                        break;
                    case 1:
                        RectangularSkin();
                        break;
                }
            }
        }
    }
}
