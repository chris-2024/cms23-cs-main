using EnMauiApp.ViewModels;

namespace EnMauiApp.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}