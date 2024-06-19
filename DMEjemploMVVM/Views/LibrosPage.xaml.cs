using DMEjemploMVVM.Services;
using DMEjemploMVVM.ViewModels;


namespace DMEjemploMVVM.Views;

public partial class LibrosPage : ContentPage
{
	private readonly LibroViewModel _viewModel;


	public LibrosPage()
	{
		InitializeComponent();

		_viewModel = new LibroViewModel();

		var libroservice = DependencyService.Get<ILibroService>();

		var libros = libroservice.ObtenerLibro();

		_viewModel.Libros = libros;

		BindingContext = _viewModel;

	}


}