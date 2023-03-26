using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;

namespace Bussines
{
    public class autoBussines
    {
        public List<auto> Listar()
        {
            List<auto> lista = new List<auto>();

            //agrego dos instancias de auto.

            lista.Add(new auto());
            lista.Add(new auto());

            lista[0].Id = 1;
            lista[0].Modelo = "Golf";
            lista[0].Descripcion = "Auto cheto";
            lista[0].Color = "verde";
            lista[0].Fecha = DateTime.Now;
            lista[0].Usado = true;
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
