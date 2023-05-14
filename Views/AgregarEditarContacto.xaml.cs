using Prueba_Maui.Clases;

namespace Prueba_Maui.Views;

//Query; informacion que recibe de la Ventana Anterior
[QueryProperty(nameof(ContactoId),"Id")]
public partial class AgregarEditarContacto : ContentPage
{
	private Contacto _contacto = new Contacto();
	public AgregarEditarContacto()
	{
		InitializeComponent();
	}


	public string ContactoId
	{
		set
		{
			if (Convert.ToInt32(value) != -1)
			{
                _contacto = Funciones.BuscarContacto(Convert.ToInt32(value));
            }
			else
			{
			}
		}
	}

    private void btnRegresar_Clicked(object sender, EventArgs e)
    {
		Funciones.BtnPresionado = false;
        Shell.Current.GoToAsync("..");
    }
}