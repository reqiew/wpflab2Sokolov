using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
       
        
        public double TotalCost(Iviewier v, double price)
        {
            return v.Cost(price);
        }

        private void cl1_Click(object sender, RoutedEventArgs e)
        {
            StudentViewier st = new StudentViewier(int.Parse(kolpos.Text));
            res.Text = st.Cost(double.Parse(Costbilet.Text)).ToString();
            
        }

        private void cl2_Click(object sender, RoutedEventArgs e)
        {
            RegularViewier rv = new RegularViewier(int.Parse(kolpos.Text));
            res.Text = ((Iviewier)rv).Cost(double.Parse(Costbilet.Text)).ToString();
        }
    }
}