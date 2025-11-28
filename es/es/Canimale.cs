using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    abstract class Canimale
    {
        public string nome { get; set; }
        protected string immagine_path;
        protected string verso_path;

        public string getversopath()
        {
            return verso_path;
        }
    }
}
