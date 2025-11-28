using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Cgatto : Canimale
    {
        public Cgatto() : base()
        {
            base.nome = "doggo base";
            base.immagine_path = "cans.jpg";
            base.verso_path = "cats.wav";
        }

        public Cgatto(string nome) : base()
        {
            base.nome = nome;
            base.immagine_path = "gatts.jpg";
            base.verso_path = "cats.wav";
        }

        public string getversopath()
        {
            return getversopath();
        }
    }
}
