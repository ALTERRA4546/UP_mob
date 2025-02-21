using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_10_Xamarin.MVVM.Model;
using Ticket_10_Xamarin.MVVM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ticket_10_Xamarin.MVVM.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MarsView : ContentPage
	{
		public MarsView ()
		{
			InitializeComponent();

			LoadData();
		}

		private async void LoadData()
		{
            MarsViewModel viewModel = new MarsViewModel();
            List<MarsModel> list = await viewModel.LoadMarsData();
			myList.ItemsSource = list;
        }
	}
}