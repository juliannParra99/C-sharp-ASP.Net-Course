using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class auto
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Descripcion { get; set; }

        public string Color { get; set; }

        public DateTime Fecha { get; set; }

        public bool Usado { get; set; }

        public bool Importado { get; set; }
    }
}
