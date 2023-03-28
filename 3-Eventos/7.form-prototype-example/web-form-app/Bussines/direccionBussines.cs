using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;

namespace Bussines
{
    public class direccionBussines
    {
        public List<direccion> listar()
        {
            List<direccion> listaDireccion = new List<direccion>();
            listaDireccion.Add(new direccion());
            listaDireccion.Add(new direccion());

            listaDireccion[0].calle = "Av.Corrientes";
            listaDireccion[0].altura = 123;

            listaDireccion[1].calle = "Florida";
            listaDireccion[1].altura = 555;

            return listaDireccion;

        }

    }
}
