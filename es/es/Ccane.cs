using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Ccane : Canimale
    {
        public Ccane(): base()
        {
            base.nome = "doggo base";
            base.immagine_path = "cans.jpg";
            base.verso_path = "cans.wav";
        }

        public Ccane(string nome): base()
        {
            base.nome = nome;
            base.immagine_path = "cans.jpg";
            base.verso_path = "cans.wav";
        }

        public string getversopath()
        {
            return getversopath();
        }
    }
}
