using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580082ExamA
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            homeButton.Clicked += HomeButton_Clicked;



		}

        private void HomeButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new MainPage());
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());
            var np = new NavigationPage(tp);
            mp.Detail = np;
            mp.IsPresented = false;
        }
    }
}