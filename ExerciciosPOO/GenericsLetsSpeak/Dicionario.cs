using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLetsSpeak
{
    public class Dicionario<k, v>
    {
        private Dictionary<k, v> termo;

        public Dictionary<k, v> Termos
        {
            get { return termo; }
            set
            {
                foreach (var item in value)
                {
                    termo.Add(item.Key, item.Value);
                }
            }
        }

        public Dicionario()
        {
            termo = new Dictionary<k, v>();
        }

    }
}
