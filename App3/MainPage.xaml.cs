using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            WelcomeText.Opacity = 1;
            WelcomeText.Translation = new Vector3(0, 0, 0);
            TutorLogo.Opacity = 1;
            TutorLogo.Translation = new Vector3(0, 0, 0);
            Login.Opacity = 1;
            Login.Translation = new Vector3(0, 0, 0);
            LoginText.Opacity = 1;
            LoginText.Translation = new Vector3(0, 0, 0);
            //HotTea.Opacity = 1;
            //HotTea.Translation = new Vector3(0, 0, 0);
        }
    }
}
