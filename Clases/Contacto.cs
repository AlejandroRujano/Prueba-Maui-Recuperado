using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Prueba_Maui.Clases
{
    public class Contacto
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _apodo;
        private string _correo;
        private string _pathImagen;
        private long _numeroTelefonico;
        public Contacto()
        {
            _id = -1;
            _nombre = "Sin Nombre";
            _apellido = "Sin Apellido";
            _apodo = "Sin Apodo";
            _correo = "NoEsUnCorreo@gmail.com";
            _numeroTelefonico = 0;
            _pathImagen = "";
        }
        public Contacto(string nombre, string apellido, string apodo, string correo, long numeroTelefonico, int id)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _apodo = apodo;
            _correo = correo;
            _numeroTelefonico = numeroTelefonico;
            if(id % 2 == 0) 
            {
                _pathImagen = @"contacto.png";
            }
            else
            {
                _pathImagen = @"silueta.png";
            }
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Apodo { get { return _apodo; } set { _apodo = value; } }
        public string PathImagen { get { return _pathImagen; } set { _pathImagen = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public long NumeroTelefonico { get { return _numeroTelefonico; } set { _numeroTelefonico = value; } }
    }
}