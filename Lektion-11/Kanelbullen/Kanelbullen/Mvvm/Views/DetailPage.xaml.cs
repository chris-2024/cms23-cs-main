using Kanelbullen.ViewModels;

namespace Kanelbullen.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}