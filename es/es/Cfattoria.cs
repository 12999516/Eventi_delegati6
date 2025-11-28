using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Cfattoria
    {
        public delegate void versoriporodotto(string verso_path, string nomeanimale);
        public event versoriporodotto verso_reply;
        List<Canimale> animali;

        public Cfattoria()
        {
            animali = new List<Canimale>();
            versoriporodotto versoevento;
        }

        public void aggiungianimale(Canimale animale)
        {
            animali.Add(animale);
        }

        public void richiediverso(Canimale a)
        {
            verso_reply?.Invoke(a.getversopath(), a.nome);
        }
    }
}
