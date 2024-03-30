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

namespace EntityDatabase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameEntities context = new GameEntities();

        public MainWindow()
        {
            InitializeComponent();
            Weapons.ItemsSource = context.Weapon.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pageframe1.Content = new WeaponsTypesPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pageframe2.Content = new PlayersPage();

        }
    }
}
