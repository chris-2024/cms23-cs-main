using EnMauiApp.ViewModels;

namespace EnMauiApp.Views;

public partial class EditPage : ContentPage
{
	public EditPage(EditViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}