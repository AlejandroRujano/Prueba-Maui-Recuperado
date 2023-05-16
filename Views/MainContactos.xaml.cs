//using Java.Lang;
using Microsoft.Maui.ApplicationModel.Communication;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Prueba_Maui.Clases;
using System.Collections.ObjectModel;

namespace Prueba_Maui.Views;
public partial class MainContactos : ContentPage
{
	//private List<Contacto> _listaDeContactos = new List<Contacto>();
    private ObservableCollection<Contacto> _listaDeContactos;
	//private int Contador = 0;
	public MainContactos()
	{
		InitializeComponent();

        Funciones.LeerJsonContactos();
        _listaDeContactos = new ObservableCollection<Contacto>(Funciones.ListaOriginal);
        //_listaDeContactos = Funciones.ListaOriginal;
		CollectionViewContactos.ItemsSource = _listaDeContactos;
	}
    /*protected override void OnAppearing()
    {
        base.OnAppearing();
    }*/
    private void btnAgregarContacto_Clicked(object sender, EventArgs e)
    {
        if (btnAgregarContacto.IsEnabled==true && Funciones.BtnPresionado == false)
        {
            Funciones.BtnPresionado = true;
            
            Shell.Current.GoToAsync($"{nameof(AgregarEditarContacto)}?Id=-1");
        }
    }
    private void CollectionViewContactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		if(CollectionViewContactos.SelectedItem != null && Funciones.BtnPresionado == false)
		{
            Funciones.BtnPresionado = true;
            Shell.Current.GoToAsync($"{nameof(AgregarEditarContacto)}?Id={((Contacto)CollectionViewContactos.SelectedItem).Id}");
        }
        CollectionViewContactos.SelectedItem = null;
    }

    private void entryBusqueda_TextChanged(object sender, TextChangedEventArgs e)
    {
        //string textoBusqueda = ((Entry)sender).Text;

        //var listaDeContactosFiltrados = new ObservableCollection<Contact>(_listaDeContactos.Where(contacto => contacto.Nombre.Contains(textoBusqueda)));

        //CollectionViewContactos.ItemsSource = listaDeContactosFiltrados;

    }
}