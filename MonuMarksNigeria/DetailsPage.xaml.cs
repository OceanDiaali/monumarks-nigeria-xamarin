using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace MonuMarksNigeria
{
    public partial class DetailsPage : ContentPage
    {

        public DetailsPage(string selectedState)
        {
            InitializeComponent();

           var wikiUrl = "https://en.wikipedia.org/wiki/" + selectedState + "_state";
           var videoUrl = "https://www.youtube.com/results?search_query=" + selectedState + "+state";

        
            SelectedWiki.Text = "Read about " + selectedState;
            SelectedVideo.Text = "Watch videos of " + selectedState;
            SelectedMap.Text = "Placeholder map for " + selectedState;

            SelectedWiki.GestureRecognizers.Add(new TapGestureRecognizer() 
            {
                Command = new Command(() => 
                {
                    Device.OpenUri(new Uri(wikiUrl)); 
                })
            });

            SelectedVideo.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Device.OpenUri(new Uri(videoUrl));
                })
            });

            SelectedMap.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Map.OpenAsync(9.0882, 7.4934, new MapLaunchOptions
                    {
                        Name = "Test",
                        NavigationMode = NavigationMode.Driving
                    });
                })
            });


        } // constructor


    }
}
