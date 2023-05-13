using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Maui.Clases
{
    public class Funciones
    {
        private static List<Contacto> _listaDeContactosOriginal = new List<Contacto>();
        private static bool _btnPresionado = false;
        public static bool BtnPresionado { get { return _btnPresionado; } set { _btnPresionado = value; } }
        public static List<Contacto> ListaOriginal { get { return _listaDeContactosOriginal;} set {  _listaDeContactosOriginal = value; } }
        public static void LeerJsonContactos()
        {
            _listaDeContactosOriginal.Clear();
            _listaDeContactosOriginal.Add(new Contacto("Luis","Galindez","Editor","a@gmail.com",24456,_listaDeContactosOriginal.Count+1));
            _listaDeContactosOriginal.Add(new Contacto("Chupa", "Paletas", "ApodoXd", "b@gmail.com", 36656, _listaDeContactosOriginal.Count + 1));
            _listaDeContactosOriginal.Add(new Contacto("Super", "Man", "SuperMan", "c@gmail.com", 75862, _listaDeContactosOriginal.Count + 1));
        }
        public static Contacto BuscarContacto(int id)
        {
            Contacto _contactoBuscado = new Contacto();

            _contactoBuscado = _listaDeContactosOriginal.First(Contacto => Contacto.Id == id);

            return _contactoBuscado;
        }
    }
}
