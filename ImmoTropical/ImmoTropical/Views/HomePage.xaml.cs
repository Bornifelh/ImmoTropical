using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImmoTropical.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class articles
    {
        public String Nom { get; set; }
        public String Prix { get; set; }
        public String Description { get; set; }

        public String Image { get; set; }
    }

    public partial class HomePage : ContentPage
    {
        List<articles> articles;


        public HomePage()
        {
            InitializeComponent();

            articles = new List<articles>();
            articles.Add(new articles { Image= "lab_logo.png", Nom = "Lait", Prix = "1500F", Description = "bqskdjqbd qjdhbqsjdbhqs qdjvhqbsdkjvhqs" });
            articles.Add(new articles { Image = "lab_logo.png", Nom = "Lait", Prix = "1500F", Description = "kjldbkjhsdbcks csdkuhbsdkjch sdkhujsdb csd ksdjhc " });
            articles.Add(new articles { Image = "lab_logo.png", Nom = "Lait", Prix = "1500F", Description = "kjldbkjhsdbcks csdkuhbsdkjch sdkhujsdb csd ksdjhc " });
            articles.Add(new articles { Image = "lab_logo.png", Nom = "Lait", Prix = "1500F", Description = "kjldbkjhsdbcks csdkuhbsdkjch sdkhujsdb csd ksdjhc " });

            MalistViewPromo.ItemsSource = articles;

            MalistViewPromo.ItemSelected += (sender, e) =>
            {
                if (MalistViewPromo.SelectedItem != null)
                {
                    articles item = MalistViewPromo.SelectedItem as articles;

                    DisplayAlert(item.Nom, item.Description, "ok");
                    MalistViewPromo.SelectedItem = null;
                }
            };
        }
        //private void ClickAjoutPanier(object sender, EventArgs e)
        //{
          //  this.Navigation.PushAsync(new HomePage());
        //}
    }
}

