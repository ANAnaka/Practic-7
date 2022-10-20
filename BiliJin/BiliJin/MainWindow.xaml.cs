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

namespace BiliJin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Pupa> pupas = new List<Pupa>();

            pupas.Add(new Pupa(87, "Квас", 65.0m));
            pupas.Add(new Pupa(47, "Пивас", 80.0m));
            pupas.Add(new Pupa(45, "Рубас", 1.0m));

            GGLv.ItemsSource=pupas;
        }
    }
}
