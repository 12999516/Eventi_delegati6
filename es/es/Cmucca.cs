using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Cmucca : Canimale
    {
        public Cmucca() : base()
        {
            base.nome = "doggo base";
            base.immagine_path = "muccs.jpg";
            base.verso_path = "muccs.wav";
        }

        public Cmucca(string nome) : base()
        {
            base.nome = nome;
            base.immagine_path = "muccs.jpg";
            base.verso_path = "muccs.wav";
        }

        public string getversopath()
        {
            return getversopath();
        }
    }
}
