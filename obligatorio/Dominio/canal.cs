using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Canal
    {
        #region atributos

        private int id;
        private static int ultId;
        private string nombre;
        private int resolucion;
        private bool multilenguaje;
        private decimal precio;

        #endregion

        #region propiedades

        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Resolucion
        {
            get { return resolucion; }
        }

        public bool Multilenguaje
        {
            get { return multilenguaje; }
        }

        public decimal Precio
        {
            get { return precio; }
        }

        #endregion


    }
}
