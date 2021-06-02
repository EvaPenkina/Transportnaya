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
using System.Windows.Shapes;

namespace Transportnaya.Windowst
{
    /// <summary>
    /// Логика взаимодействия для AddPer.xaml
    /// </summary>
    public partial class AddPer : Window
    {
        public AddPer()
        {
            InitializeComponent();
        }

        private void Back2_Click(object sender, RoutedEventArgs e)
        {
            Perevozciki window = new Perevozciki();
            window.Show();
            Close();
        }
    }
}
