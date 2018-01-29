using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LongPressedTestApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			var pageModel = new MainPageViewModel();

			pageModel.Message = "Welcome to Xamarin.Forms!";
			pageModel.LongPressed = new Command(() => {
				pageModel.Message = "Long pressed";
			});

			BindingContext = pageModel;
		}
	}
}
