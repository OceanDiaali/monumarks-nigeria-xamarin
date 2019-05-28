using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Xamarin.Essentials;

namespace MonuMarksNigeria
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            MoveImage();
        }

        void MoveImage() 
        {
           //if (Arrow.Y == 100) 
           //{
                //Arrow.TranslateTo(0, -100, 3000);
            //} else 
            //{
               Arrow.TranslateTo(0, 100, 3000);
            //}
        }



        async void Handle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

           


            if (selectedIndex != -1) 
            { 
                var selection = (string)picker.ItemsSource[selectedIndex];
                var detailPage = new DetailsPage(selection);
                //detailPage.BindingContext = selection;
                //BindingContext = selection;
                await Navigation.PushAsync(detailPage);
                //await Navigation.PushAsync(new DetailsPage());
            }



            ;
        

        //if (selectedIndex != -1) 
        //{
        //    await Browser.OpenAsync("https://en.wikipedia.org/wiki/"+selectedIndex.ToString()+"_state"); 
        //}


        //if (selectedIndex != -1)
        //{
        //    SelectedState.Text = "Taking you to " + (string)picker.ItemsSource[selectedIndex] + " page..";
        //    SelectedState.IsVisible = true;
        //}
    } // handle event method

    } // main class
} // namespace
