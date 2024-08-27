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
using dataacces;

namespace _2fa
{
    /// <summary>
    /// Page1.xaml etkileşim mantığı
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        int deger_random;

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            //rastgele sayı üreterek kullanıcının mailine göndeerir ve sayıyı data access katmanına ulastıtır
            Random rnd = new Random();
            deger_random = rnd.Next(1000, 9999);
            dataacces.dataaccess dtc = new dataacces.dataaccess();
           
           // dtc.mail_gonder(Convert.ToString(deger_random));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox_1.Text.Length != 4)
            {
                MessageBox.Show("fazla veya eksik karakter girdiniz");


            }
            //maile gönderilen kod girilen deger ile eslesiyormu karsılastıtır
            if (deger_random == int.Parse(textbox_1.Text))
            {
                MessageBox.Show("basarılı");

            }
            else
            {
                MessageBox.Show("basarısız");
            }





        }



    }
}
