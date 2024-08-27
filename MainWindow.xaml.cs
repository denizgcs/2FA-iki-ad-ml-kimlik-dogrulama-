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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using data;
using dataacces;
namespace _2fa
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        data.data dt = new data.data();
        dataacces.dataaccess dtc = new dataacces.dataaccess();
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //data access katmanına giris bilgileri gönderir
            dtc.giris(ad.Text, parola.Text);





            //giris bilgileri gogru veya hatalı ise duruma göre yönlendirir
            if (dt.Dogrula == true)
            {
                
                frame.Width = 900;
                

                frame.Height = 550;
                frame.NavigationService.Navigate(new Page1());





            }
            else if (dt.Dogrula == false)
            {
                MessageBox.Show("ad veya parola hatalı");
            }





        }
    }
}
