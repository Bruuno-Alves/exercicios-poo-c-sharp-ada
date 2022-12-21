using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCaneta
{
    public class Caneta
    {
        public string Marca { get; set; }
        public string CorCarga { get; set; }
        public string CorTubo { get; set; }
        public double Ponta { get; set; }

        public override string ToString()
        {
            return $"A caneta da marca {Marca} tem a carga da cor {CorCarga}, o tubo da cor {CorTubo} e a ponta de {Ponta}mm";
        }
    }
}
