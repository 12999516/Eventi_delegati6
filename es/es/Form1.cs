using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        Cfattoria fattoria;
        Ccane cane;
        Cgatto gatto;
        Cmucca mucca;
        public Form1()
        {
            InitializeComponent();
            fattoria = new Cfattoria();
            cane = new Ccane("diesel");
            gatto = new Cgatto("biscotto");
            mucca = new Cmucca("pancake");
            fattoria.aggiungianimale(cane);
            fattoria.aggiungianimale(gatto);
            fattoria.aggiungianimale(mucca);
            fattoria.verso_reply += onplay;
            pct_cane.Image = Properties.Resources.cans1;
            pct_cane.SizeMode = PictureBoxSizeMode.Zoom;
            pct_gatto.Image = Properties.Resources.gats1;
            pct_gatto.SizeMode = PictureBoxSizeMode.Zoom;
            pct_mucca.Image = Properties.Resources.muccs1;
            pct_mucca.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void onplay(string verso_path, string nomeanimale)
        {

            SoundPlayer player = new SoundPlayer(verso_path);
            player.Play();

            switch(nomeanimale)
            {
                case "diesel":
                    lbl_cane.Text = $"il cane {nomeanimale} fa bau";
                    break;
                case "biscotto":
                    lbl_gatto.Text = $"il gatto {nomeanimale} fa miao";
                    break;
                case "pancake":
                    lbl_mucca.Text = $"la mucca {nomeanimale} fa muuu";
                    break;
            }

        }

        private void pct_cane_Click(object sender, EventArgs e)
        {
            fattoria.richiediverso(mucca);
        }

        private void pct_gatto_Click(object sender, EventArgs e)
        {
            fattoria.richiediverso(gatto);
        }

        private void pct_mucca_Click(object sender, EventArgs e)
        {
            fattoria.richiediverso(cane);
        }
    }
}
