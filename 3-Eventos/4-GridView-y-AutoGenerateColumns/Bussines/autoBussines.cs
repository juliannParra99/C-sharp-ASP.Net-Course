using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;

namespace Bussines
{
    //la clase negocio se suele utilizar para generar una conexion a una base de datos pero en este caso la vamos a utilizar
    //para mostrar algunos datos referidos a la clase domain; que va a devolver una lista estatica de autos

    //es un moKapp; una devoluciond de datos de ejemplo para trabajar sobre algo;
    //con esto vamos a mostrar con una grilla en ASP
    public class autoBussines
    {

        //este metodo lo voy a utilizar para mostrar estos datos en un data grid view: para esto uso el code behind de 
        //la pagina aspx
        public List<auto> Listar()
        {
            List<auto> lista = new List<auto>();

            //agrego dos instancias de auto.

            lista.Add(new auto());
            lista.Add(new auto());

            lista[0].Id = 1;
            lista[0].Modelo = "Golf";
            lista[0].Descripcion = "Auto cheto";
            lista[0].Color = "verde" ;
            lista[0].Fecha = DateTime.Now ;
            lista[0].Usado = true ;
            lista[0].Importado = true;

            lista[1].Id = 2;
            lista[1].Modelo = "Audi";
            lista[1].Descripcion = "Buena nave";
            lista[1].Color = "negro";
            lista[1].Fecha = DateTime.Now;
            lista[1].Usado = false;
            lista[1].Importado = false;


            return lista;

        }

    }
}
